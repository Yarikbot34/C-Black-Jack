using System;
using System.Net.Mime;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Threading;
using CardLib;
using CrupieLib;
using StackLib;
using UserLib;

namespace BlackJack_0._2._1.Properties
{
    public partial class GameForm : Form
    {
        public int userBallance, userBet;
        private User user;
        private Crupie crupie;
        public bool endGame = false;
        public Stack stack;
        public byte userScore = 0;
        public byte difficulty;
        public bool btnMove;
        public GameForm(byte diff)
        {
            InitializeComponent();
            user = new User();
            crupie = new Crupie();
            userBallance = 500;
            inputBet.Enabled = true;
            difficulty = diff;

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
            btnMove = false;
            userBet = Convert.ToInt32(inputBet.Value);
            inputBet.Maximum = userBallance;
            if (userBet > 0)
            {
                buttonAddCard.Hide();
                buttonApplyGame.Hide();
                buttonAddCard.Location = new Point(360, 345);
                buttonApplyGame.Location = new Point(360, 380);
                Console.WriteLine(buttonApplyGame.Location);
                userBallance -= Convert.ToInt32(inputBet.Text);
                labelBallance.Text = userBallance.ToString();
                buttonApplyBet.Enabled = false;
                buttonClearBet.Enabled = false;
                userScore = 0;
                endGame = false;
                stack = new Stack();
                stack.NewStack();
                user.GetCards(stack);
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
            // Карты игрока
            for (byte i = 0; i < 5; i++)
            {
                if (user.cards[i] != null)
                {
                    UserCards[i].Visible = true;
                    UserCards[i].BackgroundImage = user.cards[i].CardImage();
                }
                else
                {
                    if (!(btnMove) && !endGame && i > 2)
                    {
                        buttonAddCard.Visible = true;
                        buttonApplyGame.Visible = true;
                        buttonAddCard.Location = new Point(buttonAddCard.Location.X + 70, buttonAddCard.Location.Y);
                        buttonApplyGame.Location = new Point(buttonApplyGame.Location.X + 70, buttonApplyGame.Location.Y);
                        btnMove = true;
                    }
                    else if (i < 2)
                    { btnMove = true;}
                    UserCards[i].Visible = false;
                }
            }
            //Карты крупье/второго игрока
            for (byte i = 0; i < 5; i++)
            {
                if (crupie.cards[i] != null)
                {
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
            btnMove = false;
        }

        private void calculateScore()
        {
            userScore = user.GetScore();
            if (userScore > 20)
            {
                endGameStart();
            }
            else
            {
                labelScore.Text = userScore.ToString();
            }
        }

        private void endGameStart()
        {
            endGame = true;
            if (userScore < 21)
            {
                crupie.crupieGame(userScore, stack, difficulty);
                int User2Score = crupie.GetScore();
                printCards();
                if (userScore > User2Score || User2Score > 21)
                {
                    gameResult.ForeColor = Color.Green;
                    gameResult.Text = "You Win!";
                    userBallance += userBet*2;
                }
                else if (userScore == User2Score && userScore < 22)
                {
                    gameResult.ForeColor = Color.Black;
                    gameResult.Text = "Ничья!";
                    userBallance += userBet;
                }
                else
                {
                    gameResult.ForeColor = Color.Red;
                    gameResult.Text = "Вы проиграли";
                }
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
            buttonAddCard.Hide(); 
            buttonApplyGame.Hide();
            Console.WriteLine($"AddCard Visible: {buttonAddCard.Visible}, ApplyGame Visible: {buttonApplyGame.Visible}");
            Update();
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
            buttonAddCard.Hide();
            buttonApplyGame.Hide();
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

        private void buttonToMenu_Click(object sender, EventArgs e)
        {
            NewGamePrepare();
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }
    }
    
}