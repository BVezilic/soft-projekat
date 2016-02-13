// File:    Card.cs
// Author:  STOLE
// Created: Monday, February 08, 2016 5:21:35 PM
// Purpose: Definition of Class Card

using System;

public class Card
{
    #region Attributes
    private Suit suit;
    private Value value;

    public Suit Suit
    {
        get
        {
            return suit;
        }

        set
        {
            suit = value;
        }
    }

    public Value Value
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
    #endregion

    #region Constructors
    public Card()
    {
        suit = Suit.s;
        value = Value.a;
    }
   
    public Card(Card oldCard)
    {
        suit = oldCard.suit;
        value = oldCard.value;
    }

    public Card(Suit suit, Value value)
    {
        this.suit = suit;
        this.value = value;
    }

    #endregion

    public override string ToString()
    {   
        
        string retVal = "";

        switch ((int)Value)
        {
            case 11:
                retVal += "J";
                break;
            case 12:
                retVal += "Q";
                break;
            case 13:
                retVal += "K";
                break;
            case 14:
                retVal += "A";
                break;
            default:
                retVal += (int)Value;
                break;
        }


        retVal += "|";

        switch ((int)Suit)
        {
            case 0:
                retVal += "H";
                break;
            case 1:
                retVal += "S";
                break;
            case 2:
                retVal += "D";
                break;
            case 3:
                retVal += "C";
                break;
        }

        return retVal;
           
    }
}