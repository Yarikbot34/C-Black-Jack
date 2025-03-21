using System;
using System.Drawing.Printing;
using CardLib;
using StackLib;

namespace CrupieLib
{
    public class Crupie
    {
        public Card[] crupieStack = new Card[5];
        private int crupieScore = 0;

        public Card[] crupieGetCard(Stack stack)
        {
            crupieStack[0] = stack.GiveCard();
            crupieStack[1] = stack.GiveCard();
            crupieScore = crupieStack[0].GetPrice() + crupieStack[1].GetPrice();
            return crupieStack;
        }

        public void crupieGame(byte userScore, Stack stack, byte difficulty, Card[] crupieCards)
        {
            foreach (Card i in crupieCards)
            {
                if (i == null)
                {
                    int index = Array.IndexOf(crupieCards, i);
                    if ((userScore > crupieScore && userScore < 20 || crupieScore < 10) && index < 5 && difficulty == 3)
                    {
                        crupieCards[index] = stack.GiveCard();
                        crupieScore += crupieCards[index].GetPrice();
                    }
                    else if ((userScore > crupieScore && userScore < 15 || crupieScore < 10) && index < 5 && difficulty == 2)
                    {
                        crupieCards[index] = stack.GiveCard();
                        crupieScore += crupieCards[index].GetPrice();
                    }
                    else if ( crupieScore < 10 && index < 5 && difficulty == 1)
                    {
                        crupieCards[index] = stack.GiveCard();
                        crupieScore += crupieCards[index].GetPrice();
                    }
                    else
                    {
                        break;
                    }   
                }
            }
            crupieStack = crupieCards;
            
        }

        public int getCrupieScore()
        {
            return crupieScore;
        }
    }
}