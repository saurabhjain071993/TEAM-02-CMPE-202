using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;



#region "prototype pattern"
//public class StripCache:MonoBehaviour
//{
//    static GameObject strip;

//    public static void loadCache(GameObject[] poolOfStripsPrefabs,GameObject lastStrip)
//    {
//        // A) we take a strip from the pool of strips prefabs at random
//        // B) then we instantiate it at the location of the last item of the "strips" list and add the width of this item as an offset (X axis)

//        // A)
//        int stripsPrefabCount = poolOfStripsPrefabs.Length;
//        int randomNumber = Random.Range (0, stripsPrefabCount);
//        GameObject item = poolOfStripsPrefabs [randomNumber] as GameObject;
//        //Transform itemChildTransform = item.transform.GetChild(0) as Transform;
//        //Transform itemChildOfChildTranform = itemChildTransform.GetChild (0) as Transform;
//        //float itemWidth = itemChildOfChildTranform.gameObject.GetComponent<Renderer> ().bounds.size.x;
//        float itemWidth = 10.2f; // static width

//        // get location of the last item:
//        //GameObject lastStrip = strips [strips.Count - 1] as GameObject;

//        strip = Instantiate (item, lastStrip.transform.position, lastStrip.transform.rotation) as GameObject;
//        strip.transform.position = new Vector3 (strip.transform.position.x -  itemWidth, strip.transform.position.y, strip.transform.position.z);
//    }

//    public static GameObject getStrip()
//    {
//        return strip;
//    }
//}
#endregion

//Component

//public interface IScoreCalculator
//{
//    int getScore ();
//}

//Concrete Component
//public class ScoreCalculator: IScoreCalculator
//{
	
//    int currScore;
//    public ScoreCalculator(int currScore)
//    {
		
//        this.currScore = currScore;
//    }
//    public int getScore()
//    {
//        Debug.Log ("In getScore");
//        return currScore;
//    }
//    public void invokeAction()
//    {

//    }
//}


//Decorator
//public class ScoreDecorator: IScoreCalculator
//{
//    private IScoreCalculator scoreCalculator;

//    public ScoreDecorator(IScoreCalculator s)
//    {
		
//        this.scoreCalculator = s;
//    }
//    public virtual int getScore()
//    {
//        return scoreCalculator.getScore();
//    }
//}


//ConcreteDecoratorA
//public class CoinScoreDecorator: ScoreDecorator
//{
//    private int addedPoints;

//    public CoinScoreDecorator(IScoreCalculator s):base(s)
//    {
//    }

//    public override int getScore()
//    {
//        addedPoints = base.getScore ();
//        return addedScore (addedPoints);
//    }

//    public int addedScore(int points)
//    {
//        return points + 2;
//    }

//}


//ConcreteDecoratorB
//public class StripScoreDecorator: ScoreDecorator
//{
//    private int addedPoints;

//    public StripScoreDecorator(IScoreCalculator s):base(s)
//    {

//    }

//    public override int getScore()
//    {
//        addedPoints = base.getScore ();
//        return addedScore (addedPoints);
//    }

//    public int addedScore(int points)
//    {
//        return points + 1;
//    }

//}

// Bhargav's Decorator Pattern

//public interface ILocation
//{
//    float getLocation ();
//}

//Concrete Component
//public class ChickenLocation: ILocation
//{

//    float currPosition;
//    public ChickenLocation(float currPosition)
//    {

//        this.currPosition = currPosition;
//    }
//    public float getLocation()
//    {
//        Debug.Log ("In getScore");
//        return currPosition;
//    }
//}


//Decorator
//public class LocationDecorator: ILocation
//{
//    private ILocation location;

//    public LocationDecorator(ILocation l)
//    {

//        this.location = l;
//    }
//    public virtual float getLocation()
//    {
//        return location.getLocation();
//    }
//}

//ConcreteDecoratorC
//public class UpLocationDecorator: LocationDecorator
//{
//    private float addedLocation;

//    public UpLocationDecorator(ILocation s):base(s)
//    {

//    }

//    public override float getLocation()
//    {
//        addedLocation = base.getLocation ();
//        return updatedPosition (addedLocation);
//    }

//    public float updatedPosition(float x)
//    {
//        return x - ( 30.0f * Time.deltaTime);
//    }

//}


//ConcreteDecoratorA
//public class RightLocationDecorator: LocationDecorator
//{
//    private float addedLocation;

//    public RightLocationDecorator(ILocation s):base(s)
//    {

//    }

//    public override float getLocation()
//    {
//        addedLocation = base.getLocation ();
//        return updatedPosition (addedLocation);
//    }

//    public float updatedPosition(float x)
//    {
//        return x + ( 30.0f * Time.deltaTime);
//    }

//}


//ConcreteDecoratorB
//public class LeftLocationDecorator: LocationDecorator
//{
//    private float addedLocation;

//    public LeftLocationDecorator(ILocation s):base(s)
//    {

//    }

//    public override float getLocation()
//    {
//        addedLocation = base.getLocation ();
//        return updatedPosition (addedLocation);
//    }

//    public float updatedPosition(float x)
//    {
//        return x - ( 30.0f * Time.deltaTime);
//    }

//}


 
//ConcreteDecoratorD
//public class DownLocationDecorator: LocationDecorator
//{
//    private float addedLocation;

//    public DownLocationDecorator(ILocation s):base(s)
//    {

//    }

//    public override float getLocation()
//    {
//        addedLocation = base.getLocation ();
//        return updatedPosition (addedLocation);
//    }

//    public float updatedPosition(float x)
//    {
//        return x + ( 30.0f * Time.deltaTime);
//    }

//}







public class PlayerCharacterScript : MonoBehaviour {

	bool isJumpingUp;
	bool isJumpingDown;
	bool isJumpingLeft;
	bool isJumpingRight;

	bool gameIsPlaying = false;
	public GameObject startPanel;
	public GameObject gameOverPanel;
	public GameObject pausePanel;

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
	public GameObject strip15;
	public GameObject strip16;
	public GameObject strip17;

	public int score = 0;
	public int coinScore = 0;
	public Text scoreText;
	public Text scoreText1;
	public int indexOfTheHighestRoadStrip = 0;

	public GameObject BoundaryLeft;
	public GameObject BoundaryRight;

	public float jumpDistanceZ = 2.0f;

	private List<GameObject> strips;
	int stripsCurrentIndex;

	public GameObject[] poolOfStripsPrefabs;

	public GameObject mesh;

	float jumpOffsetX = 2.5f;

	public Vector3 JumpTargetLocation;
	public float movingSpeed = 100.0f;

	private float midWayPointX;
	public float jumpHeightIncrement = 2.0f;

	private float initialPositionY;

	private bool isDead = false;
	private bool isPlayingDeathAnimation = false;

	public AudioClip coinClip;
	public AudioClip gameClip;
	public AudioClip gameOverClip;

    private TagSubject tagSubject;
    private IObserver observer;

	// Use this for initialization
	void Start () {

        tagSubject = new TagSubject();
        observer = new ScoreObserver(tagSubject);
        tagSubject.attach(observer);
        observer = new ObjectActionObserver(tagSubject);
        tagSubject.attach(observer);

		HidePausePanel ();

		strips = new List<GameObject>();
		isJumpingUp = isJumpingDown = isJumpingRight = isJumpingLeft = false;

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
		strips.Add (strip15); //strip15.name = "15";
		strips.Add (strip16); //strip16.name = "16";
		strips.Add (strip17); //strip17.name = "17";

		stripsCurrentIndex = 0;
		initialPositionY = this.transform.position.y;

		HideGameOverPanel ();


		int isGameReloaded = PlayerPrefs.GetInt ("reloaded");
		if (isGameReloaded == 1) {
			PlayerPrefs.SetInt("reloaded", 0);
			ButtonStartPressed();

		}

		int isGameResumed = PlayerPrefs.GetInt ("resumed");
		if (isGameResumed == 1) {
			PlayerPrefs.SetInt("resumed", 0);
			this.GetComponent<AudioSource> ().PlayOneShot (gameClip);
			gameIsPlaying = true;
			startPanel.SetActive (false);
         }	
	}
	
	// Update is called once per frame
	void Update () {

        //tagSubject = new TagSubject();
        //observer = new ScoreObserver(tagSubject);
        //tagSubject.attach(observer);
        //observer = new ObjectAction(tagSubject);
        //tagSubject.attach(observer);

		if (gameIsPlaying == false) {
			return;
		}

		if (isDead == true) {
			return;
		}
		/*if (Input.GetMouseButtonDown (0)) {
			if(isJumping == false )
			{
				isJumping = true;
				Jump ();
			}
		}*/

		if (isJumpingUp) {
			if (this.transform.position.x > JumpTargetLocation.x) {

				ILocation loc = new UpLocationDecorator (new ChickenLocation (this.transform.position.x));
			
				//score = scoreCalculator1.getScore ();

				float addToLocation = loc.getLocation ();

				this.transform.position = new Vector3 (addToLocation, this.transform.position.y, this.transform.position.z);
				if (this.transform.position.x > midWayPointX) {
					this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + jumpHeightIncrement * Time.deltaTime, this.transform.position.z);
				} else {
					this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y - jumpHeightIncrement * Time.deltaTime, this.transform.position.z);
				}
			} else {
				isJumpingUp = false;
				this.transform.position = new Vector3 (transform.position.x, initialPositionY, transform.position.z);
			}
		} else if (isJumpingDown) {
			// todo
			if (this.transform.position.x < JumpTargetLocation.x) {
				ILocation loc = new DownLocationDecorator (new ChickenLocation (this.transform.position.x));

				//score = scoreCalculator1.getScore ();

				float addToLocation = loc.getLocation ();
				this.transform.position = new Vector3 (addToLocation, this.transform.position.y, this.transform.position.z);
				if (this.transform.position.x < midWayPointX) {
					this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + jumpHeightIncrement * Time.deltaTime, this.transform.position.z);
				} else {
					this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y - jumpHeightIncrement * Time.deltaTime, this.transform.position.z);
				}
			} else {
				isJumpingDown = false;
				this.transform.position = new Vector3 (transform.position.x, initialPositionY, transform.position.z);
			}
		} else if (isJumpingLeft) {
			if (this.transform.position.z > JumpTargetLocation.z) {
				ILocation loc = new LeftLocationDecorator (new ChickenLocation (this.transform.position.z));

				//score = scoreCalculator1.getScore ();

				float addToLocation = loc.getLocation ();
				this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y, addToLocation);
				if (this.transform.position.z > midWayPointX) {
					this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + jumpHeightIncrement * Time.deltaTime, this.transform.position.z);
				} else {
					this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y - jumpHeightIncrement * Time.deltaTime, this.transform.position.z);
				}
			} else {
				isJumpingLeft = false;
				this.transform.position = new Vector3 (transform.position.x, initialPositionY, transform.position.z);
			}
		} else if (isJumpingRight) {
			Debug.Log (movingSpeed + "****************");
			if (this.transform.position.z < JumpTargetLocation.z) {
				ILocation loc = new RightLocationDecorator (new ChickenLocation (this.transform.position.z));

				//score = scoreCalculator1.getScore ();

				float addToLocation = loc.getLocation ();
				this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y, addToLocation);
				if (this.transform.position.z < midWayPointX) {
					this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + jumpHeightIncrement * Time.deltaTime, this.transform.position.z);
				} else {
					this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y - jumpHeightIncrement * Time.deltaTime, this.transform.position.z);
				}
			} else {
				isJumpingRight = false;
				this.transform.position = new Vector3 (transform.position.x, initialPositionY, transform.position.z);
			}
		}

		if (isPlayingDeathAnimation == true) {
			UpdateDeathAnimation();
		}

	
	}


	void JumpUp() {
		if(gameIsPlaying == false)
			return;
		// we want to move to the next strip on the field
		//this.transform.position = new Vector3 (strip5.transform.position.x, transform.position.y, transform.position.z);

		// A) move the strips current index by 1 (increment)
		// B) get the strip at this index within the strips list
		// C) get the x position of this new stip and apply it to the chicken

		// A)
		stripsCurrentIndex += 1;
		if (stripsCurrentIndex > indexOfTheHighestRoadStrip) {
            tagSubject.setPlayer(this);
            tagSubject.setTag("strip");
            indexOfTheHighestRoadStrip = stripsCurrentIndex;
			Debug.Log("new  score: " + indexOfTheHighestRoadStrip.ToString());
		}

		// B)
		GameObject nextStrip = strips [stripsCurrentIndex] as GameObject;

		// C)
		JumpTargetLocation = new Vector3 (nextStrip.transform.position.x - jumpOffsetX, transform.position.y, transform.position.z);
		midWayPointX = JumpTargetLocation.x + ((this.transform.position.x - JumpTargetLocation.x) / 2);
		mesh.transform.localEulerAngles = new Vector3 (0, 0, 0);

		//SpawnNewStrip ();
		GameObject lastStrip = strips [strips.Count - 1] as GameObject;
		StripCache.loadCache (poolOfStripsPrefabs, lastStrip);
		strips.Add (StripCache.getStrip());

		// todo: move boundy up
		// we need to to figure out the distance that the chicken will travel as it jumps
		float distanceX = this.transform.position.x - JumpTargetLocation.x;
		BoundaryLeft.transform.position -= new Vector3 (distanceX, 0, 0);
		BoundaryRight.transform.position -= new Vector3 (distanceX, 0, 0);
	}

    public void destroyObject(Collider other)
    {
        Debug.Log("destroy coin 1234");
        Destroy(other.gameObject);
    }

    public void killPlayer()
    {
        DeathAnimation();
    }

	void OnTriggerEnter(Collider other){
        tagSubject.setOther(other);
        tagSubject.setPlayer(this);
        if (other.gameObject.tag == "coin") {
            
            tagSubject.setTag("coin");
			Debug.Log("Before123"+score);
            //IScoreCalculator scoreCalculator1 = new CoinScoreDecorator (new ScoreCalculator (score));

            //score = scoreCalculator1.getScore ();
            //Debug.Log("After"+score);
            ////Increase the Score by one point and add sound
            ////Also destroy the coin
            //Debug.Log("Collision with Coin");
            ////score += 2;
            //scoreText.text = "score: " + score.ToString();

			this.GetComponent<AudioSource> ().PlayOneShot (coinClip);

			//Disapperaing the Coin when collected
            //destroyObject(other);
			
		}
		if (other.gameObject.tag == "Enemy") {
            tagSubject.setTag("Enemy");
			//Debug.Log("collision");
            //killPlayer();
		}

		if (other.gameObject.tag == "obstacle") {
			Debug.Log ("hit an obstacle");
            tagSubject.setTag("obstacle");

			float offsetUpDown = 0;
			float offsetLeftRight = 0;
			// todo:
			if(isJumpingDown){
				offsetUpDown = -2.0f;
			}
			else if(isJumpingUp){
				offsetUpDown = 2.0f;
			}
			else if(isJumpingRight){
				offsetLeftRight = -2.0f;
			}
			else if(isJumpingLeft){
				offsetLeftRight = 2.0f;
			}

			transform.position = new Vector3(transform.position.x + offsetUpDown, initialPositionY, transform.position.z + offsetLeftRight);

			isJumpingUp = isJumpingRight = isJumpingLeft = isJumpingDown = false;
		}
	}

	void DeathAnimation(){
		isPlayingDeathAnimation = true;
	}

	void UpdateDeathAnimation(){
		if (mesh.transform.localScale.z > 0.1) {
			mesh.transform.localScale -= new Vector3 (0, 0, 0.02f);
		} else {
			isPlayingDeathAnimation = false;
			isDead = true;
			BringUpGameOverPanel();
		}
		if (mesh.transform.rotation.eulerAngles.x == 0 || mesh.transform.rotation.eulerAngles.x > 270) {
			mesh.transform.Rotate(-4.0f, 0, 0);
		}

	}

	void SwipeUp(){
		Debug.Log ("consuming swipe up");
		// todo: move chicken up
		if(isJumpingUp == false )
		{
			isJumpingUp = true;
			JumpUp ();
		}
	}

	void SwipeDown(){
		Debug.Log ("consuming swipe down");
		// todo move chicken down
		if(isJumpingDown == false )
		{
			isJumpingDown = true;
			JumpDown ();
		}
	}

	void SwipeLeft(){
		Debug.Log ("consuming swipe left");
		// todo: chicken moving left
		if(isJumpingLeft == false )
		{
			isJumpingLeft = true;
			JumpLeft ();
		}
	}

	void SwipeRight(){
		Debug.Log ("consuming swipe right");
		// todo: chicken moving right
		if(isJumpingRight == false )
		{
			isJumpingRight = true;
			JumpRight ();
		}
	}
	
	void JumpDown(){
			if(gameIsPlaying == false)
				return;
		// A)
		stripsCurrentIndex -= 1;
		if (stripsCurrentIndex < 0) {
			stripsCurrentIndex = 0;
			return;
		}

		
		// B)
		GameObject previousStrip = strips [stripsCurrentIndex] as GameObject;
		
		// C)
		JumpTargetLocation = new Vector3 (previousStrip.transform.position.x - jumpOffsetX, transform.position.y, transform.position.z);
		midWayPointX = JumpTargetLocation.x - ((JumpTargetLocation.x - this.transform.position.x) / 2);

		mesh.transform.localEulerAngles = new Vector3 (0, 180, 0);

		// todo: move boundary down
		float distanceX = JumpTargetLocation.x - this.transform.position.x;
		BoundaryLeft.transform.position += new Vector3 (distanceX, 0, 0);
		BoundaryRight.transform.position += new Vector3 (distanceX, 0, 0);
	}

	void JumpRight(){
		if(gameIsPlaying == false)
			return;
		JumpTargetLocation = new Vector3 (transform.position.x, transform.position.y, transform.position.z + jumpDistanceZ);
		midWayPointX = JumpTargetLocation.z + ((this.transform.position.z - JumpTargetLocation.z ) / 2);
		mesh.transform.localEulerAngles = new Vector3 (0, 90, 0);
	}

	void JumpLeft(){
		if(gameIsPlaying == false)
			return;
		JumpTargetLocation = new Vector3 (transform.position.x, transform.position.y, transform.position.z - jumpDistanceZ);
		midWayPointX = JumpTargetLocation.z - ((JumpTargetLocation.z - this.transform.position.z ) / 2);
		mesh.transform.localEulerAngles = new Vector3 (0, -90, 0);
	}


	void ButtonStartPressed(){
		Debug.Log ("button start pressed");
		this.GetComponent<AudioSource> ().PlayOneShot (gameClip);

		gameIsPlaying = true;
		startPanel.SetActive (false);
	}


	void BringUpGameOverPanel(){
		this.GetComponent<AudioSource> ().Stop ();
		
		this.GetComponent<AudioSource> ().PlayOneShot (gameOverClip);
		
		
		gameOverPanel.SetActive (true);
		Time.timeScale = 0;
	}

	void PauseGame(){
		


		gameOverPanel.SetActive (true);
	}


	void HideGameOverPanel(){
		gameOverPanel.SetActive (false);
	}

	void PlayAgain(){
		Debug.Log ("play again button pressed");
		PlayerPrefs.SetInt ("reloaded", 1);
		Time.timeScale = 1;
		Application.LoadLevel ("LEVEL_1");
	}



	void ButtonCharacterPressed() {
		Application.LoadLevel ("characterSelection");
	}

	void ButtonPausePressed() {
		this.GetComponent<AudioSource> ().Pause ();
		Debug.Log ("Pause Pressed");
		BringPausePanel ();

	}

	void BringPausePanel() {

		Time.timeScale = 0;
		
		pausePanel.SetActive (true);
	}
	void HidePausePanel() {
		pausePanel.SetActive (false);
	}

	void CharacterSelectedChicken () {
	
		Debug.Log ("Chichek Charatcer is selected");
	}

	void ButtonResumePressed () {
		Debug.Log ("Resume Button Pressed");
		this.GetComponent<AudioSource> ().Play ();
		PlayerPrefs.SetInt ("resumed", 1);
		Time.timeScale = 1;
		HidePausePanel ();

	
	}

}











