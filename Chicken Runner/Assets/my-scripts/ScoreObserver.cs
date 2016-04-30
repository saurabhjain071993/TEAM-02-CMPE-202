using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ScoreObserver : Observer
{
    public ScoreObserver(TagSubject tagSubject)
        : base(tagSubject)
    {

    }
    public override void invokeAction()
    {
        if (string.Equals(tagSubject.getTag(), "coin"))
        {
            IScoreCalculator scoreCalculator1 = new CoinScoreDecorator(new ScoreCalculator(tagSubject.getPlayer().score));

            tagSubject.getPlayer().score = scoreCalculator1.getScore();
            Debug.Log("After" + tagSubject.getPlayer().score);
            //Increase the Score by one point and add sound
            //Also destroy the coin
            Debug.Log("Collision with Coin");
            //score += 2;
            tagSubject.getPlayer().scoreText.text = "score: " + tagSubject.getPlayer().score.ToString();
        }
        else if (string.Equals(tagSubject.getTag(), "strip"))
        {
            IScoreCalculator scoreCalculator1 = new StripScoreDecorator(new ScoreCalculator(tagSubject.getPlayer().score));
            tagSubject.getPlayer().score = scoreCalculator1.getScore();
            //score += 1;
            tagSubject.getPlayer().scoreText.text = "score: " + tagSubject.getPlayer().score.ToString();
        }
        else if (string.Equals(tagSubject.getTag(), "Enemy"))
        {
            //do nothing
        }
        else if (string.Equals(tagSubject.getTag(), "obstacle"))
        {
            //do nothing
        }
    }
}

