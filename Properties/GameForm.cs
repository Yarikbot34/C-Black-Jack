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

namespace BlackJack_0._2._1.Properties
{
    public partial class GameForm : Form
    {
        private Game game;
        public int userBallance, userBet;
        public Card[] userStack;
        public Card[] crupieStack;
        public Crupie crupie;
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Close();
        }


        private void buttonApplyBet_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }

        private void buttonAddCard_Click(object xz, EventArgs ea)
        {
            foreach (Card i in userStack)
            {
                if (i == null)
                {
                    userStack[Array.IndexOf(userStack, i)] = stack.GiveCard();
                    break;
                }
            }
            calculateScore();
            printCards();
        }

        private void NewGame()
        {
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
                userStack = game.cardsOnTable(stack);
                crupie = new Crupie();
                crupieStack = crupie.crupieGetCard(stack);
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
                if (userStack[i] != null)
                {
                    UserCards[i].Visible = true;
                    UserCards[i].BackgroundImage = userStack[i].CardImage();
                }
                else
                {
                    UserCards[i].Visible = false;
                }
            }
            for (byte i = 0; i < 5; i++)
            {
                if (crupieStack[i] != null)
                {
                    if (i > 0 && endGame)
                    {
                        Thread.Sleep(500);
                    }
                    CrupieCards[i].Visible = true;
                    if (i == 1 && !endGame)
                    {
                        crupieStack[i].hiden = true;
                    }
                    else
                    {
                        crupieStack[i].hiden = false;
                    }
                    CrupieCards[i].BackgroundImage = crupieStack[i].CardImage();
                }
                else
                {
                    CrupieCards[i].Visible = false;
                }
            }
        }

        private void calculateScore()
        {
            userScore = 0;
            foreach (Card i in userStack)
            {
                if (i != null)
                {userScore += (byte)i.GetPrice();}
            }
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
            crupie.crupieGame(userScore, stack, game.difficulty, crupieStack);
            crupieStack = crupie.crupieStack;
            int crupieScore = crupie.getCrupieScore();
            printCards();
            if (userScore > crupieScore && userScore < 21)
            {
                gameResult.ForeColor = Color.Green;
                gameResult.Text = "You Win!";
                userBallance += userBet*2;
            }
            else if (userScore == crupieScore && userScore < 22)
            {
                gameResult.ForeColor = Color.Yellow;
                gameResult.Text = "Ничья!";
                userBallance += userBet;
            }
            else if (userScore == 21)
            {
                gameResult.ForeColor = Color.ForestGreen;
                gameResult.Text = "Блэкджек!";
                userBallance += userBet * 3;
            }
            else
            {
                gameResult.ForeColor = Color.DarkRed;
                gameResult.Text = "Вы проиграли";
            }
            endGame = false;
            labelBallance.Text = userBallance.ToString();
            gameResult.Enabled = true;
        }

        private void buttonApplyGame_Click(object sender, EventArgs e)
        {
            endGameStart();
        }

        private void buttonClearBet_Click(object sender, EventArgs e)
        {
            inputBet.Text = "";
        }

        private void NewGamePrepare()
        {
            buttonApplyBet.Enabled = true;
            buttonClearBet.Enabled = true;
            inputBet.Enabled = true;
            userScore = 0;
            gameResult.Text = "";
            inputBet.Text = "";
            labelScore.Text = 0.ToString();
            endGame = false;
            userStack = new Card[5];
            crupieStack = new Card[5];
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
    }
    
}