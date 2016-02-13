// File:    TradeChecker.cs
// Author:  STOLE
// Created: Monday, February 08, 2016 5:29:26 PM
// Purpose: Definition of Class TradeChecker

using System;
using System.Collections.Generic;

public class TradeChecker
{
    #region Public Methods
    public static List<Card> TradeCards(PlayerController playerControler)
    {
        int handVal = playerControler.PlayerHand.EvaluateHand() / 1000000;
        List<Card> retVal = new List<Card>();

        switch (handVal)
        {
            case 0:
                retVal = changeHighCard(playerControler);
                break;
            case 1:
                retVal = changeOnePair(playerControler);
                break;
            case 2:
                retVal = changeTwoPairs(playerControler);
                break;
            case 3:
                retVal = changeThreeOfAKind(playerControler);
                break;
            case 4:
                retVal = changeStraight(playerControler);
                break;
            case 5:
                retVal = changeFlush(playerControler);
                break;
            case 6:
                retVal = changeFullHouse(playerControler);
                break;
            case 7:
                retVal = changeFourOfAKind(playerControler);
                break;
            case 8:
                break;
            case 9:
                break;
        }

        return retVal;
    }
    #endregion

    #region Private Methods
    private static List<Card> changeFourOfAKind(PlayerController playerControler)
    {
        List<Card> retVal = new List<Card>();
        int highCard = playerControler.PlayerHand.EvaluateHand() % 100;
        int boundry = 0;
        switch (playerControler.Player.Mood)
        {
            case Mood.good:
                boundry = 10;
                break;
            case Mood.neutral:
                boundry = 7;
                break;
            case Mood.bad:
                boundry = 5;
                break;
        }

        if (highCard < boundry)
        {
            foreach(Card card in playerControler.PlayerHand.Cards)
            {
                if ((int)(card.Value) == highCard)
                {
                    retVal.Add(card);
                    break;
                }
            }
        }

        return retVal;
    }

    private static List<Card> changeFullHouse(PlayerController playerControler)
    {
        return new List<Card>();
    }

    private static List<Card> changeFlush(PlayerController playerControler)
    {
        return new List<Card>();
    }

    private static List<Card> changeStraight(PlayerController playerControler)
    {
        List<Card> retVal = new List<Card>();
        Dictionary<int,int> suits = new Dictionary<int, int>();

        if(playerControler.Player.Mood == Mood.good)
        {
            foreach(Card card in playerControler.PlayerHand.Cards)
            {
                if (suits.ContainsKey((int)(card.Suit)))
                {
                    suits[(int)(card.Suit)]++;
                }
                else
                {
                    suits.Add((int)(card.Suit), 1);
                }
            }

            if (suits.ContainsValue(4))
            {
                foreach (Card card in playerControler.PlayerHand.Cards)
                {
                    if (suits[(int)(card.Suit)] != 4)
                    {
                        retVal.Add(card);
                        break;
                    }             
                }
            }
        }
        

        return new List<Card>();
    }

    private static List<Card> changeThreeOfAKind(PlayerController playerControler)
    {
        List<Card> retVal = new List<Card>();
        int checkCard = ((playerControler.PlayerHand.EvaluateHand() % 1000000) / 10000) / 3;
        int highCard = playerControler.PlayerHand.EvaluateHand() % 100;
        int tempCard = 0;
        foreach (Card card in playerControler.PlayerHand.Cards)
        {
           
            if ((tempCard = (int)(card.Value)) != checkCard)
            {
                if((playerControler.Player.Mood == Mood.good) || (playerControler.Player.Mood == Mood.neutral && (tempCard < 10 && highCard == tempCard)) || (highCard != tempCard) || (playerControler.Player.Mood == Mood.bad && (tempCard < 6 && highCard == tempCard) || (highCard != tempCard)))
                {
                    retVal.Add(card);        
                }
            }
        }

        return retVal;
    }

    private static List<Card> changeTwoPairs(PlayerController playerControler)
    {
        List<Card> retVal = new List<Card>();
        int sedonCard = ((playerControler.PlayerHand.EvaluateHand() % 10000) / 100) / 2;
        int highHand = playerControler.PlayerHand.EvaluateHand() % 100;
        foreach (Card card in playerControler.PlayerHand.Cards)
        {
            if (playerControler.Player.Mood == Mood.bad)
            {
                if(((int)(card.Value)==highHand) && highHand < 7)
                {
                    retVal.Add(card);
                }
            }
            if (playerControler.Player.Mood == Mood.neutral)
            {
                if ((int)(card.Value) == highHand)
                {
                    retVal.Add(card);
                }
            }
            if (playerControler.Player.Mood == Mood.good)
            {
                if (((int)(card.Value) == highHand) || (((int)(card.Value) == sedonCard) && sedonCard<7))
                {
                    retVal.Add(card);
                }
            }
        }

        return retVal;
    }

    private static List<Card> changeOnePair(PlayerController playerControler)
    {
        List<Card> retVal = new List<Card>();
        int firstCard = ((playerControler.PlayerHand.EvaluateHand() % 1000000) / 10000) / 2;
        int highHand = playerControler.PlayerHand.EvaluateHand() % 100;
        foreach (Card card in playerControler.PlayerHand.Cards)
        {
            if (playerControler.Player.Mood == Mood.bad)
            {
                if ((int)(card.Value) != firstCard)
                {
                    retVal.Add(card);
                }
            }
            if (playerControler.Player.Mood == Mood.neutral)
            {
                if (((int)(card.Value) != firstCard))
                {
                    if (((int)(card.Value) != firstCard) && (((int)(card.Value) < 7 && ((int)(card.Value) == highHand)) || ((int)(card.Value) != highHand)))
                        {
                        retVal.Add(card);
                    }
                }
            }
            if (playerControler.Player.Mood == Mood.good)
            {
                if ((int)(card.Value) != firstCard && (int)(card.Value) != highHand)
                {
                    retVal.Add(card);
                }
            }
        }
        return retVal;
    }

    private static List<Card> changeHighCard(PlayerController playerControler)
    {
        List<Card> retVal = new List<Card>();
        int highHand = playerControler.PlayerHand.EvaluateHand() % 100;

        foreach(Card card in playerControler.PlayerHand.Cards)
        {
            if((int)(card.Value) != highHand)
            {
                retVal.Add(card);
            }
        }

        return retVal;
    }
    #endregion
}
//c,4 d,4 d,4 c,2 h,a