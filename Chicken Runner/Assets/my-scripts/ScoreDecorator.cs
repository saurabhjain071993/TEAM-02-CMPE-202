using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ScoreDecorator : IScoreCalculator
{
    private IScoreCalculator scoreCalculator;

    public ScoreDecorator(IScoreCalculator s)
    {

        this.scoreCalculator = s;
    }
    public virtual int getScore()
    {
        return scoreCalculator.getScore();
    }
}