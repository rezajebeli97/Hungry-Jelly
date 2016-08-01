using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Jelly : MonoBehaviour {
	private Rigidbody2D myRigidbody,brickRigidbody;
	private Vector2 velocityVector,vectorDown,vectorUp,initialLocale;
	public GameObject Chocalte,Food,Brick/*,angryBrick*/;
	private Animator myAnimator;
	public Text showHealth;

	private int maxLevel=2;
	private bool jump = false, hit = false;



/////////////////////////////////////////////////////////////////////////////////////

	void Start () {
		myRigidbody = this.GetComponent<Rigidbody2D> ();
		myAnimator = this.GetComponent<Animator> ();

		print (Health_Level.level);
//		brickRigidbody = Brick.GetComponent<Rigidbody2D> ();

		showHealth.text = Health_Level.health.ToString();

		initialLocale = myRigidbody.transform.position;
	}


/////////////////////////////////////////////////////////////////////////////////////

	void FixedUpdate () {

		hit = false;

		JumpJelly ();

		VelocityReduction ();
		GameOver ();
//		print (myRigidbody.velocity);
//		MoveJelly ();
//		if (Mathf.Abs( myRigidbody.velocity.x ) < 0.25 && Mathf.Abs( myRigidbody.velocity.y) < 0.25  && jump ) {
//			print (myRigidbody.velocity.x);
//			print (myRigidbody.velocity.y);
//		}
	}

/////////////////////////////////////////////////////////////////////////////////////

	private void OnCollisionEnter2D(Collision2D coll) {
		switch (coll.gameObject.name) {

//		case "Right":
//			hit = true;
//			break;
//
//		case "Left":
//			hit = true;
//			break;
//
//		case "Up":
//			hit = true;
//			break;
//
//		case "Down":
//			hit = true;
//			break;
//
//		case "BrickAngry":
//			hit = true;
//			break;

//		case "Right":
//			myAnimator.SetTrigger ("HitWallRight");
//			StopJelly ();
//			for (int i = 0; i < 5000; i++) {
//				print ("hello");
//			}
//			break;

//		case "Brick":
//			hit = true;
	//		Destroy (Brick);
	//		Instantiate(angryBrick , brickRigidbody.transform.position,brickRigidbody.transform.rotation);
//			break;

		case "Chocolate":
			Destroy (Chocalte);
			Health_Level.health++;
			showHealth.text = Health_Level.health.ToString();
			break;

		case "Food":
			Destroy (Food);
			jump = false;
			myRigidbody.velocity = Vector2.zero;
			levelUp ();
			break;
		}
		
	}

/////////////////////////////////////////////////////////////////////////////////////

	void levelUp(){
		if (Health_Level.level == maxLevel) {
			print ("tamoomesh kardi ke:|");
		} 
		else {
			Health_Level.level++;
			print (Health_Level.level);
			Application.LoadLevel (Health_Level.level);
		}
	}

//////////////////////////////////////////////////////////////////////////////////

	private void StopJelly(){
		float a = velocityVector.x;
		float b = velocityVector.y;
		velocityVector = Vector2.zero;
		myRigidbody.velocity = velocityVector;
	//	System.Threading.Thread.Sleep (1000);
	
	}


//////////////////////////////////////////////////////////////////////////////////

	private void MoveJelly(){
//		if()
	
	}
		
/////////////////////////////////////////////////////////////////////////////////////

	private void JumpJelly(){
		if (!jump) {

			if (Input.GetMouseButtonDown (0)) {
				vectorDown = Input.mousePosition;
			}

			if (Input.GetMouseButtonUp (0) ) {

				vectorUp = Input.mousePosition;

			

				velocityVector.x = (vectorUp.x - vectorDown.x)/35;
				velocityVector.y = (vectorUp.y - vectorDown.y)/35;


				myRigidbody.velocity = velocityVector;
				if(vectorUp.x != vectorDown.x || vectorUp.y != vectorDown.y)
				jump = true;
			//	print (Input.mousePosition);
			}
		}
	
	}

//////////////////////////////////////////////////////////////////////////////////

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
		
//////////////////////////////////////////////////////////////////////////////////

//	private void VelocityReduction(){
//		//		velocityVector = myRigidbody.velocity;
//
//		if (myRigidbody.velocity.y > 0) {
//			myRigidbody.velocity.y -= velocityVector.y/150;
//		}
//		else 
//			myRigidbody.velocity.y -= myRigidbody.velocity.y/150;
//
//		if(myRigidbody.velocity.x > 0) 
//			myRigidbody.velocity.x -= myRigidbody.velocity.x/150;
//		else 
//			myRigidbody.velocity.x -= myRigidbody.velocity.x/150;
//
////		myRigidbody.velocity = velocityVector;				//bug mide
//	}

//////////////////////////////////////////////////////////////////////////////////

	private void GameOver(){
		if (Mathf.Abs( myRigidbody.velocity.x ) < 0.25 && Mathf.Abs( myRigidbody.velocity.y) < 0.25 && jump) {
			
			if (Health_Level.health == 0) {
				Destroy (myRigidbody);
				Application.LoadLevel (3);
				return;
			} 

			else {
				Health_Level.health--;
				showHealth.text = Health_Level.health.ToString();		//va inke jelle az paiine safhe shooroo be bazi kone
				jump=false;
				myRigidbody.transform.position = initialLocale;
				myRigidbody.velocity = Vector2.zero;
			}
		}
	
	}

}
