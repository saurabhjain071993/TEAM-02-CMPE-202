using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ObjectAction : Observer
{
    public ObjectAction(TagSubject tagSubject)
        : base(tagSubject)
    {

    }
    public override void invokeAction()
    {
        Debug.Log("objct action invoke 420");
        if (string.Compare(tagSubject.getTag(), "coin", true) == 0)
        {
            // global::System.Windows.Forms.MessageBox.Show("Test");
            Debug.Log("invokeAction coin destroy");
            Collider other = tagSubject.getOther();
            tagSubject.getPlayer().destroyObject(other);
        }
        else if (string.Equals(tagSubject.getTag(), "strip"))
        {
            //do nothing
        }
        else if (string.Equals(tagSubject.getTag(), "Enemy"))
        {
            tagSubject.getPlayer().killPlayer();
        }
        else if (string.Equals(tagSubject.getTag(), "obstacle"))
        {
            //do nothing
        }
    }

}