using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerBot
{
    class Deck
    {
        const int NUM_OF_CARDS = 52;
        private Card[] deck;

        public Card[] MyDeck
        {
            get { return deck; }
            set { deck = value; }
        }

        public Deck()
        {
            deck = new Card[NUM_OF_CARDS];
            setUpDeck();
        }

        public void setUpDeck()
        {
            int i = 0;
            foreach (SUIT suit in Enum.GetValues(typeof(SUIT)))
            {
                foreach (VALUE value in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card(suit, value);
                    i++;
                }
            }
            ShuffleCards();
        }

        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;

            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for (int i = 0; i < NUM_OF_CARDS; i++)
                {
                    int secondCardIndex = rand.Next(NUM_OF_CARDS);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }
    }
}
