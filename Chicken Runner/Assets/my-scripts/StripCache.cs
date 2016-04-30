using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class StripCache:MonoBehaviour
{
	static GameObject strip;

	public static void loadCache(GameObject[] poolOfStripsPrefabs,GameObject lastStrip)
	{
		// A) we take a strip from the pool of strips prefabs at random
		// B) then we instantiate it at the location of the last item of the "strips" list and add the width of this item as an offset (X axis)

		// A)
		int stripsPrefabCount = poolOfStripsPrefabs.Length;
		int randomNumber = UnityEngine.Random.Range (0, stripsPrefabCount);
		GameObject item = poolOfStripsPrefabs [randomNumber] as GameObject;
		//Transform itemChildTransform = item.transform.GetChild(0) as Transform;
		//Transform itemChildOfChildTranform = itemChildTransform.GetChild (0) as Transform;
		//float itemWidth = itemChildOfChildTranform.gameObject.GetComponent<Renderer> ().bounds.size.x;
		float itemWidth = 10.2f; // static width

		// get location of the last item:
		//GameObject lastStrip = strips [strips.Count - 1] as GameObject;

		strip = Instantiate (item, lastStrip.transform.position, lastStrip.transform.rotation) as GameObject;
		strip.transform.position = new Vector3 (strip.transform.position.x -  itemWidth, strip.transform.position.y, strip.transform.position.z);
	}

	public static GameObject getStrip()
	{
		return strip;
	}
}