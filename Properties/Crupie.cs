using System;
using CardLib;
using StackLib;
using UserLib;

namespace CrupieLib
{
    public class Crupie : User
    {
        private int score;
        public void crupieGame(byte userScore, Stack stack, byte difficulty)
        {
            score = GetScore();
            foreach (Card i in cards)
            {
                if ((i == null && score < userScore && score < 21) && userScore < 22)
                {
                    int index = Array.IndexOf(cards, i);
                    if (userScore > 21)
                    {
                        Console.WriteLine("Diller pass");
                    }
                    else if ( score < 10 && index < 5 && difficulty == 1)
                    {
                        Console.WriteLine($"Diller add card, {userScore}, {score}, way {difficulty}");
                        cards[index] = stack.GiveCard();
                        score += cards[index].GetPrice();
                    }
                    else if ((userScore > score && userScore < 15 || score < 10) && index < 5 && difficulty == 2)
                    {
                        Console.WriteLine($"Diller add card, {userScore}, {score}, way {difficulty}");
                        cards[index] = stack.GiveCard();
                        score += cards[index].GetPrice();
                    }
                    else if ((userScore > score && userScore < 20 || score < 10) && index < 5 && difficulty == 3)
                    {
                        Console.WriteLine($"Diller add card, {userScore}, {score}, way {difficulty}");
                        cards[index] = stack.GiveCard();
                        score += cards[index].GetPrice();
                    }
                    else
                    {
                        break;
                    }   
                }
            }
            
        }
    }
}