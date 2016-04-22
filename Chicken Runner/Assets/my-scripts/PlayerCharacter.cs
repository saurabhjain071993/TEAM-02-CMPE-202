using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class PlayerCharacterScript : MonoBehaviour {

	bool isJumpingUp;

	public GameObject strip1;
	public GameObject strip2;
	public GameObject strip3;
	public GameObject strip4;
	public GameObject strip5;
	public GameObject strip6;
	public GameObject strip7;
	public GameObject strip8;
	public GameObject strip9;
	public GameObject strip10;
	public GameObject strip11;
	public GameObject strip12;
	public GameObject strip13;
	public GameObject strip14;

	private List<GameObject> strips;
	int stripsCurrentIndex;

	//Use this for initialization
	void Start () {
		strips = new List<GameObject>();
		isJumping = false;

		strips.Add (strip1); //strip1.name = "1";
		strips.Add (strip2); //strip2.name = "2";
		strips.Add (strip3); //strip3.name = "3";
		strips.Add (strip4); //strip4.name = "4";
		strips.Add (strip5); //strip5.name = "5";
		strips.Add (strip6); //strip6.name = "6";
		strips.Add (strip7); //strip7.name = "7";
		strips.Add (strip8); //strip8.name = "8";
		strips.Add (strip9); //strip9.name = "9";
		strips.Add (strip10); //strip10.name = "10";
		strips.Add (strip11); //strip11.name = "11";
		strips.Add (strip12); //strip12.name = "12";
		strips.Add (strip13); //strip13.name = "13";
		strips.Add (strip14); //strip14.name = "14";

		stripsCurrentIndex = 0;

	}



	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if(isJumping == false) {
				isJumping = true;
				Jump(); // Simple call the Jump function when mouse button event is detected
			}
		}
	}

	void Jump() {
		//With this function we will move the chicken to next strip
		//I will update this function later
	}