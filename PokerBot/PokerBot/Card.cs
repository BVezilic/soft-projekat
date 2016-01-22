using System;
using System.Collections.Generic;
using System.Text;

namespace Poker_AI
{
    class Card
    {
        
        private int value;

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value; 
            }
        }

        private String suite;

        public String Suite{
            get
            {
                return suite;
            }
            set
            {
                this.suite = value;
            }
        }

        public Card(int value, String suite)
        {
            this.value = value;
            this.suite = suite;
        }

        public override String ToString()
        {
            return value.ToString() + suite;
        }

        

    }
}
