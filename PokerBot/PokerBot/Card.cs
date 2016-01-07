using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerBot
{
    public enum SUIT
    {
        HEARTS,
        SPADES,
        DIAMONDS,
        CLUBS
    }

    public enum VALUE
    {
        TWO = 2, THREE, FOUR, FIVE, SIX, SEVEN,
        EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
    }

    class Card
    {
        private SUIT suit;
        private VALUE value;

        public SUIT Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public VALUE Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Card(SUIT suit, VALUE value)
        {
            this.suit = suit;
            this.value = value;
        }
    }
}
