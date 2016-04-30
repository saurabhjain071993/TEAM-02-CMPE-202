using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TagSubject : ITagSubject
{
    string tag;
    PlayerCharacterScript player;
    Collider other;

    List<IObserver> observers = new List<IObserver>();

    public void attach(IObserver obj)
    {
        observers.Add(obj);
    }
    public void detach(IObserver obj)
    {
        observers.Remove(obj);
    }
    public void notifyObservers()
    {
        int i = 1;
        foreach (IObserver obj in observers)
        {
            obj.invokeAction();
        }
    }

    public string getTag()
    {
        return tag;
    }

    public void setTag(string tag)
    {
        Debug.Log("inside setTag 333333333333333333");
        this.tag = tag;
        notifyObservers();
    }

    public void setPlayer(PlayerCharacterScript player)
    {
        this.player = player;
    }
    public PlayerCharacterScript getPlayer()
    {
        return this.player;
    }

    public void setOther(Collider other)
    {
        this.other = other;
    }
    public Collider getOther()
    {
        return other;
    }


}
