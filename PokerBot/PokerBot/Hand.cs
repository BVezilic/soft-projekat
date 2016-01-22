using System;
using System.Collections.Generic;
using System.Text;


namespace Poker_AI
{
    class Hand
    {
        private List<Card> cardsInHand = new List<Card>();

        private Card firstHigh;

        internal Card FirstHigh
        {
            get { return firstHigh; }
            set { firstHigh = value; }
        }

        private Card secondHigh;

        internal Card SecondHigh
        {
            get { return secondHigh; }
            set { secondHigh = value; }
        }

        public List<Card> CardsInHand 
        {
            get
            {
                return cardsInHand;
            }
            set
            {
                cardsInHand = value;
            }
        }


        public void addCard(Card card)
        {
            cardsInHand.Add(card);
        }

        public void removeCard(int index)
        {
            cardsInHand.RemoveAt(index);
        }

        public void removeCard(Card card)
        {
            cardsInHand.Remove(card);
        }

        public override string ToString()
        {
            List<String> cards = new List<string>();
            foreach (Card card in cardsInHand)
            {
                cards.Add(card.ToString());
            }
            
            return string.Join(" ", cards.ToArray()); ;
        }

        public string checkHand()
        {
            if (isFourOfAKind())
            {
                return "Four of a Kind " + firstHigh.ToString();
            }
            else if (isFullHouse())
            {
                return "Full House " + firstHigh.ToString() + " " + secondHigh.ToString();
            }
            else if(isThreeOfAKind())
            {
                return "ThreeOfAKind " + firstHigh.ToString();
            }
            else if(isTwoPairs())
            {
                return "Two Pairs " + firstHigh.ToString() + " " + secondHigh.ToString();
            }
            else if(isPair())
            {
                return "One Pair " + firstHigh.ToString();
            }
            return "";
        }

        public void removeAll()
        {
            cardsInHand.Clear();
        }

        public bool isFourOfAKind()
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            foreach(Card card in cardsInHand)
            {
                if (values.ContainsKey(card.Value))
                {
                    int val;
                    values.TryGetValue(card.Value, out val);
                    val++;
                    values.Remove(card.Value);
                    values.Add(card.Value, val);
                    if (val == 4)
                    {
                        firstHigh = card;
                        return true;
                    }
                }
                else
                {
                    values.Add(card.Value, 1);
                }
            }

            return false;
        }

        public bool isFullHouse()
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            
            
            foreach (Card card in cardsInHand)
            {
                if (values.ContainsKey(card.Value))
                {
                    int val;
                    values.TryGetValue(card.Value, out val);
                    val++;
                    values.Remove(card.Value);
                    values.Add(card.Value, val);
                    
                    if (val == 3)
                    {
                        firstHigh = card;
                    }
                }
                else
                {
                    values.Add(card.Value, 1);
                }
            }

            foreach (Card card in cardsInHand)
            {
                int temp;
                values.TryGetValue(card.Value, out temp);
                if (temp == 2)
                {
                    secondHigh = card;
                }
            }

            return values.ContainsValue(3)&&values.ContainsValue(2) ? true : false;
        }

        public bool isThreeOfAKind()
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            foreach (Card card in cardsInHand)
            {
                if (values.ContainsKey(card.Value))
                {
                    int val;
                    values.TryGetValue(card.Value, out val);
                    val++;
                    values.Remove(card.Value);
                    values.Add(card.Value, val);
                    if (val == 3)
                    {
                        firstHigh = card;
                        return true;
                    }
                }
                else
                {
                    values.Add(card.Value, 1);
                }
            }

            return false;
        }

        public bool isTwoPairs()
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            List<Card> cards = new List<Card>();

            foreach (Card card in cardsInHand)
            {
                if (values.ContainsKey(card.Value))
                {
                    int val;
                    values.TryGetValue(card.Value, out val);
                    val++;
                    values.Remove(card.Value);
                    values.Add(card.Value, val);
                    if (val == 2)
                    {
                        cards.Add(card);
                    }
                }
                else
                {
                    values.Add(card.Value, 1);
                }
            }

            if (cards.Count > 1)
            {
                if (cards.ToArray()[0].Value > cards.ToArray()[1].Value)
                {
                    firstHigh = cards.ToArray()[0];
                    secondHigh = cards.ToArray()[1];
                }
                else
                {
                    firstHigh = cards.ToArray()[1];
                    secondHigh = cards.ToArray()[0];
                }
            }

            return cards.Count > 1 ? true : false;
        }

        public bool isPair()
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            foreach (Card card in cardsInHand)
            {
                if (values.ContainsKey(card.Value))
                {
                    int val;
                    values.TryGetValue(card.Value, out val);
                    val++;
                    values.Remove(card.Value);
                    values.Add(card.Value, val);
                    if (val == 2)
                    {
                        firstHigh = card;
                        return true;
                    }
                }
                else
                {
                    values.Add(card.Value, 1);
                }
            }

            return false;
        }
    }
}
