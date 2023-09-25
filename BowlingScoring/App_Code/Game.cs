using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Game
{

    private int currentFrame { get; set; }
    public bool isLastFrame { get; set; }
    public string player { get; set; }

    private int[] rolls;
    private int currentRoll;
    public Game()
    {
        rolls = new int[21];
        currentRoll = 0;
        currentFrame = 1;
    }
    public void Roll(int pins)
    {
        rolls[currentRoll++] = pins;

        if (currentFrame < 10 && (IsStrike(currentRoll - 1) || currentRoll % 2 == 0))
        {
            currentFrame++;
        }
    }

    public int CurrentFrame
    {
        get { return currentFrame; }
    }

    public int Score()
    {
        int score = 0;
        int rollIndex = 0;

        for (int frame = 0; frame < 10; frame++)
        {
            if (IsStrike(rollIndex))
            {
                score += 10 + StrikeBonus(rollIndex);
                rollIndex++;
            }
            else if (IsSpare(rollIndex))
            {
                score += 10 + SpareBonus(rollIndex);
                rollIndex += 2;
            }
            else
            {
                score += SumOfBallsInFrame(rollIndex);
                rollIndex += 2;
            }
        }

        return score;
    }

    private bool IsStrike(int rollIndex)
    {
        return rolls[rollIndex] == 10;
    }

    private bool IsSpare(int rollIndex)
    {
        return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
    }

    private int StrikeBonus(int rollIndex)
    {
        return rolls[rollIndex + 1] + rolls[rollIndex + 2];
    }

    private int SpareBonus(int rollIndex)
    {
        return rolls[rollIndex + 2];
    }

    private int SumOfBallsInFrame(int rollIndex)
    {
        return rolls[rollIndex] + rolls[rollIndex + 1];
    }
}