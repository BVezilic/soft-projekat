// File:    Hand.cs
// Author:  STOLE
// Created: Monday, February 08, 2016 5:21:36 PM
// Purpose: Definition of Class Hand

using System;
using System.Collections.Generic;

public class Hand
{
    #region Attributes
    private List<Card> cards;

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
    #endregion
    
    #region Constructors
    public Hand()
    {
        this.Cards = new List<Card>();
    }

    public Hand(List<Card> cards)
    {
        this.Cards = cards;
    }


    public Hand(Hand newHand)
    {
        this.Cards = newHand.Cards;
    }

    public Hand(String cards)
    {
        Cards = CardFactory.GetCards(cards);
    }
    #endregion

    #region Methods
    public void AddCards(Card newCard)
    {
        if (newCard == null)
            return;
        if (this.cards == null)
            this.cards = new List<Card>();
        if (!this.cards.Contains(newCard))
            this.cards.Add(newCard);
    }

    public void RemoveCard(Card oldCard)
    {
        if (oldCard == null)
            return;
        if (this.cards != null)
            if (this.cards.Contains(oldCard))
                this.cards.Remove(oldCard);
    }

    public void RemoveCard(int index)
    {

        if (this.cards != null) { 
            this.cards.RemoveAt(index);
        }
    }

    public bool RemoveAllCards()
    {
        if (cards != null) { 
            cards.Clear();
            return true;
        }
        return false;
    }

    public bool AddCard(Card card)
    {
        int i = cards.Count;
        cards.Add(card);
        if (i == cards.Count)
        {
            return false;
        }
        return true;
    }

    public int EvaluateHand()   
    {
        return HandEvaluator.EvaluateHand(this);
    }
    #endregion

    public override string ToString()
    {
        string retVal = "";
        foreach(Card card in Cards)
        {
            retVal += card.ToString() + " ";
        }
        return retVal;
    }
}