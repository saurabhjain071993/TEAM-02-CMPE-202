using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class RightLocationDecorator : LocationDecorator
{
    private float addedLocation;

    public RightLocationDecorator(ILocation s)
        : base(s)
    {

    }

    public override float getLocation()
    {
        addedLocation = base.getLocation();
        return updatedPosition(addedLocation);
    }

    public float updatedPosition(float x)
    {
        return x + (30.0f * Time.deltaTime);
    }

}

