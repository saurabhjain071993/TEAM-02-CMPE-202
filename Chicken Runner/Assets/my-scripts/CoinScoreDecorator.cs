using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class CoinScoreDecorator : ScoreDecorator
{
    private int addedPoints;

    public CoinScoreDecorator(IScoreCalculator s)
        : base(s)
    {
    }

    public override int getScore()
    {
        addedPoints = base.getScore();
        return addedScore(addedPoints);
    }

    public int addedScore(int points)
    {
        return points + 2;
    }

}