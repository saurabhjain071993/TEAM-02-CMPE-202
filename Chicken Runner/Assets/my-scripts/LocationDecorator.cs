using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class LocationDecorator : ILocation
{
    private ILocation location;

    public LocationDecorator(ILocation l)
    {

        this.location = l;
    }
    public virtual float getLocation()
    {
        return location.getLocation();
    }
}