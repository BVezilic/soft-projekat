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
    private double opBluff = 0;
    private double opFactor = 0;
    private int aiCurBet = 0;
    private int maxBet = 0;
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

    public double OpBluff
    {
        get
        {
            return opBluff;
        }

        set
        {
            opBluff = value;
        }
    }

    public double OpFactor
    {
        get
        {
            return opFactor;
        }

        set
        {
            opFactor = value;
        }
    }

    public int AiCurBet
    {
        get
        {
            return aiCurBet;
        }

        set
        {
            aiCurBet = value;
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

    public int EvaluateMaxBet()
    {
        int retVal = 0;

        double calculation = (double)EvaluateHand() / 9000000;

        if(calculation == 1)
        {
            return Player.Money;
        }

        calculation *= Player.Money;

        Random rnd = new Random();
        

        switch (Player.Mood)
        {
            case Mood.good:
                calculation *= (double)(100 + rnd.Next(5, 15)) / 100;
                break; 
            case Mood.neutral:
                calculation *= (double)(100 + rnd.Next(-5, 5)) / 100;
                break;
            case Mood.bad:
                calculation *= (double)(100 - rnd.Next(5, 15)) / 100;
                break;
        }

        retVal = (int)calculation;
        if (retVal == 0)
        {
            retVal++;
        }
        maxBet = retVal;
        return retVal;
    }

    public void newRound()
    {
        opBluff = 0;
        opFactor = 0;
        aiCurBet = 0;
    }

    public int makeBet(int opCurentBet, int opMoney, int opBet, bool isFirstPhase)
    {
        Random rnd = new Random();

        int retVal = 0;

        #region Modifiers
        double moneyModifier = ((Player.Money - opMoney) / (Player.Money + opMoney)) * 10;
        double aiMoodModifier = 0;
        double handModifier = (double)Math.Pow(3,(EvaluateHand() / 1000000));
        
        double alMoodFactor = 0;
        switch (Player.Mood)
        {
            case Mood.good:
                alMoodFactor = (double)rnd.Next(12, 20) / 100;
                aiMoodModifier = (double)rnd.Next(10,20);
                break;
            case Mood.neutral:
                alMoodFactor = (double)rnd.Next(6, 12) / 100;
                aiMoodModifier = (double)rnd.Next(-10, 10);
                break;
            case Mood.bad:
                alMoodFactor = (double)rnd.Next(1, 6) / 100;
                aiMoodModifier = (double)rnd.Next(-20, -10);
                break;

        }
        int aiBet = (int)(maxBet * alMoodFactor);
        double halfValueModifier = (1 - (double)(aiBet + aiCurBet + opBet) / ((double)(maxBet * 3) / 4)) * 100;
        double maxValueModifier = (1 + ((double)aiMoodModifier/100) - (double)(aiBet + aiCurBet + opBet) / (maxBet)) * 100; 

        double betModifier = moneyModifier + aiMoodModifier + handModifier + (isFirstPhase?halfValueModifier:maxValueModifier);
        #endregion

        if (betModifier > 50)
        {
            retVal = aiBet+opBet;
           
            
        }
        if (betModifier <50 && betModifier > 0)
        {
            retVal = opBet; //call
        }

        if(betModifier < 0)
        {
            retVal = 0; //fold
        }
        aiCurBet += retVal;
        player.Money -= retVal;

        return retVal;
    }
    #endregion
}//h,3 c,3 d,3 d,a h,10