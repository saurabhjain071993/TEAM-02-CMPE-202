using UnityEngine;
using System.Collections;

public class CarDriveRightSideScript : MonoBehaviour {

	private GameObject startingPoint;
	private GameObject endingPoint;

	public float speed = 23.0f;

	// Use this for initialization
	void Start () {
		startingPoint = GameObject.Find ("starting-point");
		endingPoint = GameObject.Find ("ending-point");
	
	}
	
	// Update will be crated later 
	
}
