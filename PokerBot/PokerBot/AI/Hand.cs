/***********************************************************************
 * Module:  Hand.cs
 * Author:  STOLE
 * Purpose: Definition of the Class Hand
 ***********************************************************************/

using System;
using System.Windows.Forms;
using System.Collections.Generic;
public class Hand
{
    private List<Card> cards;

    public List<Card> Cards
    {
        get
        {
            return cards;
        }

        set
        {
            cards = value;
        }
    }

    Hand(List<Card> cards)
    {
        this.Cards = cards;
        
    }

    Hand()
    {
        Cards = new List<Card>();
    }

    public bool AddCard()
   {
      // TODO: implement
      return false;
   }
   
   public bool RemoveCard()
   {
      // TODO: implement
      return false;
   }
   
   public void EvaluateHand()
   {
        HandEvaluator.EvaluateHand(cards);
   }
   
   public void TradeCards()
   {
        TradeChecker.TradeCards(cards);
   }
   
   public Hand(Card cards)
   {
      // TODO: implement
   }

   

}