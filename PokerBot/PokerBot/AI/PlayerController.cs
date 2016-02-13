// File:    PlayerController.cs
// Author:  STOLE
// Created: Tuesday, February 09, 2016 1:26:13 PM
// Purpose: Definition of Class PlayerController

using System;
using System.Collections.Generic;
public class PlayerController
{
    #region Attributes
    private Hand playerHand;
    private Player player;
    public Hand PlayerHand
    {
        get
        {
            return playerHand;
        }

        set
        {
            playerHand = value;
        }
    }

    public Player Player
    {
        get
        {
            return player;
        }

        set
        {
            player = value;
        }
    }
    #endregion

    #region Constructor
    public PlayerController()
    {
        PlayerHand = new Hand();
        Player = new Player();
    }
    public PlayerController(Hand playerHand, Player player)
    {
        this.playerHand = playerHand;
        this.player = player;
    }
    #endregion

    #region Methods
    public List<Card> TradeCards()
    {
        return TradeChecker.TradeCards(this);
    }
   
    public int EvaluateHand()
    {
        return PlayerHand.EvaluateHand();
    }

    public int makeBet()
    {
        return 0;
    }
    #endregion
}