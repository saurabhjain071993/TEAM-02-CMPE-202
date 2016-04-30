using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ScoreCalculator : IScoreCalculator
{

    int currScore;
    public ScoreCalculator(int currScore)
    {

        this.currScore = currScore;
    }
    public int getScore()
    {
        Debug.Log("In getScore");
        return currScore;
    }
    public void invokeAction()
    {

    }
}