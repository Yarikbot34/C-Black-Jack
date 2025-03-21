using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack_0._2._1.Properties;
using CrupieLib;
using StackLib;
using CardLib;

namespace BlackJack_0._2._1
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MenuForm menuForm = new MenuForm();
            Application.Run(menuForm);
        }

        public static void Game()
        {
            byte difficulty = 0;
            Stack stack = new Stack();
            Crupie crupie = new Crupie();
            stack.NewStack();
            int UserBallance = 500;
            int Bet = 0;
            while (UserBallance > 0)
            {
                Card[] userStack = new Card[5];
                Console.Clear();
                Console.Write($"Ваш балланс {UserBallance}$\nВаша ставка: ");
                Bet = Convert.ToInt32(Console.ReadLine());
                if (Bet > UserBallance)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("У вас нет таких средств");
                    Console.ResetColor();
                }
                else
                {
                    UserBallance -= Bet;
                    crupie.crupieGetCard(stack);
                    userStack[0] = stack.GiveCard();
                    userStack[1] = stack.GiveCard();
                    int userScore = userStack[1].GetPrice() + userStack[0].GetPrice();
                    byte userCardCount = 2;
                    byte userChoise = 0;
                    
                    while (userChoise != 2 && userCardCount < 5)
                    {
                        Console.WriteLine($"Карты крупье {crupie.crupieStack[0].CardName()}, ******.");
                        Console.Write($"У вас {userScore} очков, ваши карты ");
                        byte i = 0;
                        while (userStack[i] != null)
                        {
                            Console.Write(userStack[i].CardName() + "| ");
                            i++;
                        }

                        if (userScore < 21)
                        {
                            Console.Write("\nБудете брать карту?\n1-Да\n2-Нет\n");
                            userChoise = Convert.ToByte(Console.ReadLine());
                            if (userChoise == 1 )
                            {
                                userStack[userCardCount] = stack.GiveCard();
                                userScore += userStack[userCardCount].GetPrice();
                                userCardCount++;
                                Console.Clear();
                            }
                            else
                            {
                                userChoise = 2;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine($"Счёт крупье {crupie.getCrupieScore()}, ваш счёт {userScore}");
                    if (userScore == crupie.getCrupieScore())
                    {
                        Console.WriteLine("Ничья!");
                        UserBallance += Bet;
                    }
                    else if ((userScore > crupie.getCrupieScore() || crupie.getCrupieScore() > 21) && userScore < 21)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Вы победили! +{Bet * 2}$");
                        UserBallance += Bet * 2;
                        Console.ResetColor();
                    }
                    else if (userScore == 21)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Блэкджек! +{Bet * 3}$");
                        UserBallance += Bet * 3;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы проиграли");
                        Console.ResetColor();
                    }
                    Console.WriteLine("Нажмите любую кнопку для продолжения...");
                    Console.ReadKey();
                    
                    
                }
            }
            
        }
    }
}