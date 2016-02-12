// File:    Hand.cs
// Author:  STOLE
// Created: Monday, February 08, 2016 5:21:36 PM
// Purpose: Definition of Class Hand

using System;
using Sistem.Collections.Generic;

public class Hand
{
   private List<Card> cards;
   
   /// <summary>
   /// Property for collection of Card
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public List<Card> Cards
   {
      get
      {
         if (cards == null)
            cards = new List<Card>();
         return cards;
      }
      set
      {
         RemoveAllCards();
         if (value != null)
         {
            foreach (Card oCard in value)
               AddCards(oCard);
         }
      }
   }
   
   /// <summary>
   /// Add a new Card in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddCards(Card newCard)
   {
      if (newCard == null)
         return;
      if (this.cards == null)
         this.cards = new List<Card>();
      if (!this.cards.Contains(newCard))
         this.cards.Add(newCard);
   }
   
   /// <summary>
   /// Remove an existing Card from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveCards(Card oldCard)
   {
      if (oldCard == null)
         return;
      if (this.cards != null)
         if (this.cards.Contains(oldCard))
            this.cards.Remove(oldCard);
   }
   
   /// <summary>
   /// Remove all instances of Card from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllCards()
   {
      if (cards != null)
         cards.Clear();
   }
   
   public bool AddCard()
   {
      throw new NotImplementedException();
   }
   
   public bool RemoveCard()
   {
      throw new NotImplementedException();
   }
   
   public int EvaluateHand()
   {
      throw new NotImplementedException();
   }
   
   public Hand(Card cards)
   {
      throw new NotImplementedException();
   }

}