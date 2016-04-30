using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ChickenLocation : ILocation
{

    float currPosition;
    public ChickenLocation(float currPosition)
    {

        this.currPosition = currPosition;
    }
    public float getLocation()
    {
        Debug.Log("In getScore");
        return currPosition;
    }
}
