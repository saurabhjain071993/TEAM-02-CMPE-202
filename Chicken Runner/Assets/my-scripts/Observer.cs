using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Observer : IObserver
{
    protected int score;
    protected TagSubject tagSubject;

    public Observer(TagSubject tagSubject)
    {
        this.tagSubject = tagSubject;
    }

    public virtual void invokeAction()
    {
        Debug.Log("super123");
        //do nothing
    }
}