using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public interface ITagSubject
{
    void attach(IObserver obj);
    void detach(IObserver obj);
    void notifyObservers();
}