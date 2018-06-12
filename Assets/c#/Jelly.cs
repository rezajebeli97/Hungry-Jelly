using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System;

public class Jelly : MonoBehaviour {
	private Rigidbody2D myRigidbody,brickRigidbody;
	private Vector2 velocityVector,vectorDown,vectorUp,initialLocale;
//	private Animator myAnimator;
	public Text showHealth;
	private int maxLevel=2;
	private bool jump = false ,stopJely = false, onJelly = false , pkrFace=false;
	public Button pause,play;
	public Image pockerFace;
	private float stopTime,stopVelocityX,stopVelocityY;


	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void Start () {
		pause = pause.GetComponent<Button> ();
		myRigidbody = this.GetComponent<Rigidbody2D> ();
//		myAnimator = this.GetComponent<Animator> ();
		showHealth.text = Health_Level.health.ToString();
		initialLocale = myRigidbody.transform.position;

		pockerFace.enabled = false;
	}


	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void FixedUpdate () {

		JumpJelly ();
	

		VelocityReduction ();

		StartCoroutine (coRoutineGameOver ());

	}

	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//	private void OnCollisionEnter2D(Collision2D coll) {
//		
//		switch (coll.gameObject.tag) {
//		case "wall":
//			StopJelly ();
//			break;
//
//		case "rightwall":
//			StopJelly ();
//			myAnimator.SetTrigger ("HitRightWall");
//			break;
//		}
//
//	}

	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	private void OnTriggerEnter2D(Collider2D coll) {
		switch (coll.gameObject.tag) {

		case "star":
			Destroy (coll.gameObject);
			Health_Level.score += Health_Level.level * 10;
			break;
		
		case "chocolate":
			Destroy (coll.gameObject);
			Health_Level.health++;
			showHealth.text = Health_Level.health.ToString();
			break;

		case "food":
			Destroy (coll.gameObject);
			jump = false;
			myRigidbody.velocity = Vector2.zero;
			levelUp ();
			break;
		}
	}

	///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void levelUp(){
		
			Health_Level.level++;
			Application.LoadLevel (Health_Level.level);

	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void StopJelly(){
		stopVelocityX= velocityVector.x;
		stopVelocityY= velocityVector.y;
		velocityVector = Vector2.zero;
		myRigidbody.velocity = velocityVector;
		stopJely = true;
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public void moveJelly(){
		velocityVector.x = stopVelocityX;
		velocityVector.y = stopVelocityY;

		myRigidbody.velocity = velocityVector;
		stopJely = false;
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	void OnMouseDown(){
		vectorDown = Input.mousePosition;
		onJelly = true;
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	private void JumpJelly(){

		if (!jump) {

			if (Input.GetMouseButtonUp (0) && onJelly) {

				vectorUp = Input.mousePosition;
			
			
					velocityVector.x = (vectorUp.x - vectorDown.x) / 50;
					velocityVector.y = (vectorUp.y - vectorDown.y) / 50;
					
					myRigidbody.velocity = velocityVector;

				if (vectorUp.x != vectorDown.x || vectorUp.y != vectorDown.y ) {
					jump = true;
				}
				onJelly = false;
			}
		}
	
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	private void VelocityReduction(){
		velocityVector = myRigidbody.velocity;

		if (velocityVector.y > 0) {
			velocityVector.y -= velocityVector.y/150;
		}
		else 
			velocityVector.y -= velocityVector.y/150;

		if(velocityVector.x > 0) 
			velocityVector.x -= velocityVector.x/150;
		else 
			velocityVector.x -= velocityVector.x/150;

		myRigidbody.velocity = velocityVector;				//bug mide
	}

	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	IEnumerator coRoutineGameOver(){
		string savedHighScoreStr;
		int savedHighScoreInt;

		if (   Mathf.Abs( myRigidbody.velocity.x ) < 0.35 && Mathf.Abs( myRigidbody.velocity.y) < 0.35 && jump && !stopJely && !pkrFace) {
			
			if (Health_Level.health == 0) {
				Destroy (myRigidbody);
				Application.LoadLevel (maxLevel+2); 			//load GameOver Scene
				sentToServer(Health_Level.level , Health_Level.score , Health_Level.health , 4001);
			} 

			else {
				pockerFace.enabled = true;
				pkrFace = true;

				yield return new WaitForSeconds (2);

				Health_Level.health--;
				showHealth.text = Health_Level.health.ToString();		//va inke jelle az paiine safhe shooroo be bazi kone
				jump=false;
				myRigidbody.transform.position = initialLocale;
				myRigidbody.velocity = Vector2.zero;
				pockerFace.enabled = false;
				pkrFace = false;

			}
		}
	
	}



	public void sentToServer(int name1 , int name2 , int name3 , int score){	
		//http://saleh-khazaei.com/pacman/index.php?name=saleh&score=100
		//	string url = "http://saleh-khazaei.com/pacman/index.php?name="+ name + "&score=" + Move.score.ToString();
		//
		string url = "http://saleh-khazaei.com/pacman/index.php?name="+ name1.ToString()+name2.ToString()+name3.ToString() +"&score="+ score.ToString();

		//		WWWForm form = new WWWForm();
		//		form.AddField("name",name);
		//		form.AddField("Score", Move.score.ToString());
		WWW www = new WWW(url);
		StartCoroutine(WaitForRequest(www));
	}



	IEnumerator WaitForRequest(WWW www){
		yield return www;

		// check for errors
		if (www.error == null){
			print("WWW Ok!: " + www.text);
		}
		else{
			print("WWW Error: " + www.error);
		}
	}




//	public void PausePress(){
//		StopJelly ();
//	}
//
//	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	public void PlayPress(){
//		moveJelly ();
//	}

}

