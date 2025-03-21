using CardLib;
using StackLib;
using CrupieLib;


namespace GameLib
{
    public class Game
    {
        public byte difficulty = 1;
        public int Ballance = 500;
        public int Bet = 0;
        private int score = 0;
        Card[] cards = new Card[5];
        Card[] crupieCards = new Card[5];

        public Card[] cardsOnTable(Stack stack)
        {
            cards = new Card[5];
            cards[0] = stack.GiveCard();
            cards[1] = stack.GiveCard();
            return cards;

        }



    }
}