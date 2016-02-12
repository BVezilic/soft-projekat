// File:    CardFactory.cs
// Author:  STOLE
// Created: Tuesday, February 09, 2016 1:30:24 PM
// Purpose: Definition of Class CardFactory

using System;
using System.Collections.Generic;

public class CardFactory
{
   public static List<Card> GetCards(String cards)
   {
        string[] cardCollection = cards.Split(' ');
        List<Card> retVal = new List<Card>();
        Suit tempSuit;
        Value tempValue;
        foreach (string card in cardCollection)
        {
            string[] vals = card.Split(',');
            tempSuit = (Suit)Enum.Parse(typeof(Suit), vals[0]);
            tempValue = (Value)Enum.Parse(typeof(Value), vals[1]);
            retVal.Add(new Card(tempSuit,tempValue));
          
            
            
        }
        return retVal;
   }

}