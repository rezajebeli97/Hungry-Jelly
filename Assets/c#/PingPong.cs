using UnityEngine;
using System.Collections;

public class PingPong: MonoBehaviour {

	private Rigidbody2D myRigidbody;
	public float initualPosBreak = -1;
	private bool stopBrik = false;
	private float timeOfStop = 0;
	private float a;


/////////////////////////////////////////////////////////////////////////////////////

	void Start () {
		myRigidbody = this.GetComponent<Rigidbody2D> ();
	}
	
/////////////////////////////////////////////////////////////////////////////////////

	void Update () {
		if (stopBrik == false) {
			myRigidbody.transform.position = new Vector2 (Mathf.PingPong ((Time.time - timeOfStop ) * 3, 2) + initualPosBreak, myRigidbody.transform.position.y);
		}
	}

/////////////////////////////////////////////////////////////////////////////////////
	 
	public void StopBrick(){
		stopBrik = true;
		a = Time.time;
	}

/////////////////////////////////////////////////////////////////////////////////////

	public void MoveBrick(){
		stopBrik = false;
		a = Time.time - a;
		timeOfStop += a;
	}


}
