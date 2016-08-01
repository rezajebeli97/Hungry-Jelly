using UnityEngine;
using System.Collections;

public class PingPong: MonoBehaviour {

	private Rigidbody2D myRigidbody;



/////////////////////////////////////////////////////////////////////////////////////

	void Start () {
		myRigidbody = this.GetComponent<Rigidbody2D> ();
	}
	
/////////////////////////////////////////////////////////////////////////////////////

	void Update () {
		myRigidbody.transform.position = new Vector2 (Mathf.PingPong (Time.time*3, 2), myRigidbody.transform.position.y);
	}



}
