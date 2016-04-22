using UnityEngine;
using System.Collections;
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

	float jumpOffsetX = 1.5f;

	public Vector3 JumpTargetLocation;
	public float movingspeed = 100.0f;

	private float midWayPointX;
	public float jumpHeightIncrement = 2.0f;

	private float initialPositionY;

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
		initialPositionY = this.transform.position.y;

	}



	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if(isJumping == false) {
				isJumping = true;
				Jump(); // Simple call the Jump function when mouse button event is detected
			}
		}

		if (isJumping) {
			if(this.transform.position.x > JumpTargetLocation.x) {
				this.transform.position = new Vector3(this.transform.position.x - (movingspeed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
				if(this.transform.position.x > midWayPointX) {
					this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + jumpHeightIncrement * Time.deltaTime, this.transform.position.z);
				}
				else {
				this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - jumpHeightIncrement * Time.deltaTime, this.transform.position.z);	
				}
				else {
					isJumping = false;
					this.transform.position = new Vector3(transform.position.x, initialPositionY, transform.position.z);
				}
			}
		}
	

	void Jump() {
		//With this function we will move the chicken to next strip
		stripsCurrentIndex +=1;
		GameObject nextStrip = strips [stripsCurrentIndex] as GameObject;
		JumpTargetLocation = new Vector3 (nextStrip.transform.position.x - jumpOffsetX, transform.position.y,transform.position.z);
		midWayPointX = JumpTargetLocation.x + ((this.transform.position.x - JumpTargetLocation.x)/2);

		SpawnNewStrip();

	}

	void SpawnNewStrip() {
		//This Function will create a new strip dynamically on each Jump
	}

}