using System;
using System.Net.Mime;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Threading;
using GameLib;
using CardLib;
using CrupieLib;
using StackLib;
using UserLib;

namespace BlackJack_0._2._1.Properties
{
    public partial class GameForm : Form
    {
        private Game game;
        public int userBallance, userBet;
        private User user;
        private Crupie crupie;
        public bool endGame = false;
        public Stack stack;
        public byte userScore = 0;
        public GameForm(byte diff)
        {
            InitializeComponent();
            userBallance = 500;
            inputBet.Enabled = true;
            game = new Game();
            game.difficulty = diff;

        }
        private void buttonApplyBet_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }

        private void buttonAddCard_Click(object xz, EventArgs ea)
        {
            user.AddCard(stack);
            calculateScore();
            printCards();
        }

        private void NewGame()
        {
            user = new User();
            userBet = Convert.ToInt32(inputBet.Text);
            if (userBet <= userBallance && userBet > 0)
            {
                userBallance -= Convert.ToInt32(inputBet.Text);
                labelBallance.Text = userBallance.ToString();
                buttonApplyBet.Enabled = false;
                buttonClearBet.Enabled = false;
                userScore = 0;
                endGame = false;
                stack = new Stack();
                stack.NewStack();
                game.Bet = Convert.ToInt32(inputBet.Text);
                user.GetCards(stack);
                crupie = new Crupie();
                crupie.GetCards(stack);
                inputBet.Enabled = false;
                calculateScore();
                printCards();
            }
        }

        private void printCards()
        {
            Panel[] UserCards = new[] { userCard1, userCard2, userCard3, userCard4, userCard5 };
            Panel[] CrupieCards = new[] { crupieCard1, crupieCard2, crupieCard3, crupieCard4, crupieCard5 };
            for (byte i = 0; i < 5; i++)
            {
                if (user.cards[i] != null)
                {
                    UserCards[i].Visible = true;
                    UserCards[i].BackgroundImage = user.cards[i].CardImage();
                }
                else
                {
                    UserCards[i].Visible = false;
                }
            }
            for (byte i = 0; i < 5; i++)
            {
                if (crupie.cards[i] != null)
                {
                    if (i > 0 && endGame)
                    {
                        Thread.Sleep(500);
                    }
                    CrupieCards[i].Visible = true;
                    if (i == 1 && !endGame)
                    {
                        crupie.cards[i].hiden = true;
                    }
                    else
                    {
                        crupie.cards[i].hiden = false;
                    }
                    CrupieCards[i].BackgroundImage = crupie.cards[i].CardImage();
                }
                else
                {
                    CrupieCards[i].Visible = false;
                }
            }
        }

        private void calculateScore()
        {
            userScore = user.GetScore();
            labelScore.Text = userScore.ToString();
            if (userScore > 20)
            {
                endGame = true;
                endGameStart();
            }
        }

        private void endGameStart()
        {
            endGame = true;
            crupie.crupieGame(userScore, stack, game.difficulty);
            int crupieScore = crupie.GetScore();
            printCards();
            if ((userScore > crupieScore || crupieScore > 21) && userScore < 21)
            {
                gameResult.ForeColor = Color.Green;
                gameResult.Text = "You Win!";
                userBallance += userBet*2;
            }
            else if (userScore == crupieScore && userScore < 22)
            {
                gameResult.ForeColor = Color.Black;
                gameResult.Text = "Ничья!";
                userBallance += userBet;
            }
            else if (userScore == 21)
            {
                gameResult.ForeColor = Color.Green;
                gameResult.Text = "Блэкджек!";
                userBallance += userBet * 3;
            }
            else
            {
                gameResult.ForeColor = Color.Red;
                gameResult.Text = "Вы проиграли";
            }
            Console.WriteLine($"{crupieScore} {userScore}");
            endGame = false;
            buttonAddCard.Enabled = false;
            buttonApplyGame.Enabled = false;
            labelBallance.Text = userBallance.ToString();
            gameResult.Enabled = true;
        }

        private void buttonApplyGame_Click(object sender, EventArgs e)
        {
            endGameStart();
        }

        private void buttonClearBet_Click(object sender, EventArgs e)
        {
            inputBet.Text = "Ставка";
        }

        private void NewGamePrepare()
        {
            buttonApplyBet.Enabled = true;
            buttonClearBet.Enabled = true;
            buttonAddCard.Enabled = true;
            buttonApplyGame.Enabled = true;
            inputBet.Enabled = true;
            userScore = 0;
            gameResult.Text = "";
            inputBet.ForeColor = Color.Gray;
            inputBet.Text = "Ставка";
            labelScore.Text = 0.ToString();
            endGame = false;
            user.cards = new Card[5];
            crupie.cards = new Card[5];
            printCards();
        }

        private void gameResult_Click(object sender, EventArgs e)
        {
            gameResult.Enabled = false;
            NewGamePrepare();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void inputBet_Enter(object sender, EventArgs e)
        {
            if (inputBet.Text == "Ставка")
            {
                inputBet.ForeColor = Color.Black;
                inputBet.Text = "";
            }
            
        }

        private void inputBet_Leave(object sender, EventArgs e)
        {
            if (inputBet.Text == "Ставка")
            {
                inputBet.ForeColor = Color.Black;
                inputBet.Text = "";
            }
        }

        private void buttonToMenu_Click(object sender, EventArgs e)
        {
            NewGamePrepare();
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }
    }
    
}