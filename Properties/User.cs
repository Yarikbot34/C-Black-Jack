using StackLib;
using CardLib;

namespace UserLib
{
    public class User
    {
        private byte cardCount;
        public Card[] cards;
        
        public User()
        {
            
        }

        public void GetCards(Stack stack)
        {
            cards = new Card[5];
            cardCount = 1;
            while (cardCount < 3)
            {
                cards[cardCount-1] = stack.GiveCard();
                cardCount++;
            }
        }

        public void AddCard(Stack stack)
        {
            if (cardCount < 5)
            {
                cards[cardCount-1] = stack.GiveCard();
                cardCount++;
            }
        }

        public byte GetScore()
        {
            byte score = 0;
            foreach (Card card in cards)
            {
                if (card != null)
                {
                    score += (byte)card.GetPrice();
                }
            }
            return score;
        }
    }
}