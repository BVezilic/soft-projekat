// File:    Player.cs
// Author:  STOLE
// Created: Tuesday, February 09, 2016 1:26:13 PM
// Purpose: Definition of Class Player

using System;

public class Player
{
    #region Attributes
    private int money;
   
    private Mood mood;

    public int Money
    {
        get
        {
            return money;
        }

        set
        {
            money = value;
        }
    }

    public Mood Mood
    {
        get
        {
            return mood;
        }

        set
        {
            mood = value;
        }
    }
    #endregion

    #region Constructor
    public Player()
    {

    }
    
    public Player(Player player)
    {
        money = player.Money;
        mood = player.mood;
    }

    public Player(int money, Mood mood)
    {
        this.money = money;
        this.mood = mood;
    }
    #endregion

    #region Methods
    public void changeMonney(int value)
    {
        Money += value;
    }
    #endregion
}