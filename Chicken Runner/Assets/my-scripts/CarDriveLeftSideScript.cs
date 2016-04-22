using UnityEngine;
using System.Collections;

public class CarDriveLeftSideScript : MonoBehaviour {

	private GameObject startingPoint;
	private GameObject endingPoint;
	
	public float speed = 23.0f;
	
	// Use this for initialization
	void Start () {
		startingPoint = GameObject.Find ("starting-point");
		endingPoint = GameObject.Find ("ending-point");
		
	}
	
	// Update is called once per frame
	void Update () {
				
	}
}
