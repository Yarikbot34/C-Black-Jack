using CardLib;
using System;
using System.Linq;
using System.Threading;

namespace StackLib
{
    
    public class Stack
    {
        public Card[] stack = new Card[56];
        Card[] cards = new Card[5];
        public byte NewCard = 0;
        private static Random rnd = new Random();

        public void AddCard(Card card)
        {
            cards[NewCard] = card;
            NewCard++;
        }

        public void NewStack()
        {
            stack = new Card[56];
            byte i = 0, j = 0;
            while (i < 4)
            {
                while (j < 14)
                {
                    stack[(j) + i * 14] = new Card(j,i);
                    j++;
                }
                j = 0;
                i++;
            }
        }

        public void PrintStack()
        {
            int i = 0;
            while (i < 56)
            {
                Console.WriteLine(stack[i].CardName());
                i++;
            }
            
        }

        public Card GiveCard()
        {
            Card answer = null;
            while (true)
            {
                int id = 0;
                id = rnd.Next(0, stack.Length);
                if (stack[id] != null && stack[id].id % 14 != 0)
                {
                    answer = stack[id];
                    Console.WriteLine(stack[id].CardName());
                    stack[id] = null;
                    break;
                }
            }
            return answer;
            
        }

    }
}