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
            foreach (Card i in cards)
            {
                if (i == null)
                {
                    int index = Array.IndexOf(cards, i);
                    if ((userScore > score && userScore < 20 || score < 10) && index < 5 && difficulty == 3)
                    {
                        cards[index] = stack.GiveCard();
                        score += cards[index].GetPrice();
                    }
                    else if ((userScore > score && userScore < 15 || score < 10) && index < 5 && difficulty == 2)
                    {
                        cards[index] = stack.GiveCard();
                        score += cards[index].GetPrice();
                    }
                    else if ( score < 10 && index < 5 && difficulty == 1)
                    {
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