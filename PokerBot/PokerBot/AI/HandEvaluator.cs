// File:    HandEvaluator.cs
// Author:  STOLE
// Created: Monday, February 08, 2016 5:27:59 PM
// Purpose: Definition of Class HandEvaluator

using System;
using System.Collections.Generic;

public class HandEvaluator
{
    #region Methods
    public static int EvaluateHand(Hand hand)
    {
        HandEvaluator eval = new HandEvaluator();
        int retVal = 0;

        if ((retVal = eval.getFourOfAKind(hand)) > 0)
        {
            return retVal;
        }
        if(((retVal = eval.getFullHouse(hand)) > 0))
        {
            return retVal;
        }
        if (((retVal = eval.getRoyalFlush(hand)) > 0))
        {
            return retVal;
        }
        if (((retVal = eval.getStraightFlush(hand)) > 0))
        {
            return retVal;
        }
        if (((retVal = eval.getFlush(hand)) > 0))
        {
            return retVal;
        }
        if (((retVal = eval.getStraight(hand)) > 0))
        {
            return retVal;
        }
        if (((retVal = eval.getThreeOfAKind(hand)) > 0))
        {
            return retVal;
        }
        if (((retVal = eval.getTwoPairs(hand)) > 0))
        {
            return retVal;
        }
        if (((retVal = eval.getOnePair(hand)) > 0))
        {
            return retVal;
        }
        if (((retVal = eval.getHighCard(hand)) > 0))
        {
            return retVal;
        }

        return retVal; 
    }

    public int getRoyalFlush(Hand hand)
    {
        int retVal = 0;
        int check = 0;
        retVal = getStraightFlush(hand);
        check = (retVal % 1000000)/10000;
        if (check == 60)
        {
            retVal = 9000000;
            return retVal;
        }
        else {
            return 0;
        }
    }

    public int getStraightFlush(Hand hand)
    {
        int retVal = 0;
        int check = 0;
        retVal = getFlush(hand) + getStraight(hand);
        check = retVal / 1000000;
        if (check == 9)
        {
            retVal -= 1000000;
            return retVal;
        }
        else {
            return 0;
        }
    }

    public int getFourOfAKind(Hand hand)
    {
        Dictionary<int,int> check = new Dictionary<int,int>();
        int value = 0;
        foreach(Card card in hand.Cards)
        {
            value = (int)(card.Value);
            if (check.ContainsKey(value))
            {
                check[value]++;
            }
            else
            {
                check.Add(value, 1);
            }
        }

        if (check.ContainsValue(4))
        {
            int retVal = 0;
            int hcVal = 0;
            int handVal = 0;

            foreach(int i in check.Keys)
            {
                if (check[i] > 1)
                {
                    handVal = i;
                }
                else
                {
                    hcVal = i;
                }
            }


            retVal += 7 * 1000000 + 4*handVal*10000+hcVal;


            return retVal;
        }

        return 0;
    }

    public int getFullHouse(Hand hand)
    {
        Dictionary<int, int> check = new Dictionary<int, int>();
        int value = 0;
        foreach (Card card in hand.Cards)
        {
            value = (int)(card.Value);
            if (check.ContainsKey(value))
            {
                check[value]++;
            }
            else
            {
                check.Add(value, 1);
            }
        }

        if (check.ContainsValue(3)&check.ContainsValue(2))
        {
            int retVal = 0;
            int hcVal = 0;
            int handVal = 0;

            foreach (int i in check.Keys)
            {
                if (check[i] > 2)
                {
                    handVal = i;
                }
                else
                {
                    hcVal = i;
                }
            }


            retVal += 6 * 1000000 + 3 * handVal * 10000 + hcVal*2*100;


            return retVal;
        }

        return 0;
    }

    public int getFlush(Hand hand)
    {
        HashSet<int> check = new HashSet<int>();
        int value = 0;
        int maxVal = 0;
        foreach (Card card in hand.Cards)
        {
            value = (int)(card.Suit);
            if (!check.Contains(value))
            { 
                check.Add(value);
            }
            if((int)(card.Value) > maxVal)
            {
                maxVal = (int)(card.Value);
            }
        }

        if (check.Count==1)
        {
            int retVal = 0;

            retVal += 5 * 1000000 + maxVal;


            return retVal;
        }
        return 0;
    }

    public int getStraight(Hand hand)
    {
        int retVal = 0;
        int sum = 0;
        SortedSet<int> check = new SortedSet<int>();
        foreach(Card card in hand.Cards)
        {
            check.Add((int)(card.Value));
            sum += (int)(card.Value);
        }
        
        if((check.Count==5) && ((check.Max - check.Min == 4) || (check.Max == 14 && check.Min==2 && sum == 28)))
        {
            retVal = 4 * 1000000 + (sum-13) * 10000;
        }


        return retVal;
    }

    public int getThreeOfAKind(Hand hand)
    {
        Dictionary<int, int> check = new Dictionary<int, int>();
        int value = 0;
        foreach (Card card in hand.Cards)
        {
            value = (int)(card.Value);
            if (check.ContainsKey(value))
            {
                check[value]++;
            }
            else
            {
                check.Add(value, 1);
            }
        }

        if (check.ContainsValue(3))
        {
            int retVal = 0;
            int hcVal = 0;
            int handVal = 0;

            foreach (int i in check.Keys)
            {
                if (check[i] > 2)
                {
                    handVal = i;
                }
                else
                {
                    if (i > hcVal)
                    {
                        hcVal = i;
                    }
                }
            }


            retVal += 3 * 1000000 + 3 * handVal * 10000 + hcVal;


            return retVal;
        }

        return 0;
    }

    public int getTwoPairs(Hand hand)
    {
        Dictionary<int, int> check = new Dictionary<int, int>();
        int value = 0;
        foreach (Card card in hand.Cards)
        {
            value = (int)(card.Value);
            if (check.ContainsKey(value))
            {
                check[value]++;
            }
            else
            {
                check.Add(value, 1);
            }
        }

        if (check.ContainsValue(2) && check.Count == 3)
        {
            int retVal = 0;
            int hcVal = 0;
            int handVal1 = 0;
            int handVal2 = 0;
            foreach (int i in check.Keys)
            {
                if (check[i] == 2)
                {
                    if (i > handVal1)
                    {
                        handVal1 = i;
                    }
                    else
                    {
                        handVal2 = i;
                    }
                }
                else
                {
                    hcVal = i;
                }
            }


            retVal += 2 * 1000000 + 2 * handVal1 * 10000 + 2 * handVal2 * 100 + hcVal;


            return retVal;
        }

        return 0;
    }

    public int getOnePair(Hand hand)
    {
        Dictionary<int, int> check = new Dictionary<int, int>();
        int value = 0;
        foreach (Card card in hand.Cards)
        {
            value = (int)(card.Value);
            if (check.ContainsKey(value))
            {
                check[value]++;
            }
            else
            {
                check.Add(value, 1);
            }
        }

        if (check.ContainsValue(2))
        {
            int retVal = 0;
            int hcVal = 0;
            int handVal = 0;

            foreach (int i in check.Keys)
            {
                if (check[i] > 1)
                {
                    handVal = i;
                }
                else
                {
                    if (i > hcVal)
                    {
                        hcVal = i;
                    }
                }
            }


            retVal += 1000000 + 2 * handVal * 10000 + hcVal;


            return retVal;
        }

        return 0;
    }

    public int getHighCard(Hand hand)
    {
        int value = 0;
        int hcVal = 0;
        int retVal = 0;
        foreach (Card card in hand.Cards)
        {
            value = (int)(card.Value);
            if (value > hcVal)
            {
                hcVal = value;
            }
            
        }
        
        retVal += hcVal;
        return retVal;
    }
    #endregion
}


//c,3 h,k h,2 s,3 d,2