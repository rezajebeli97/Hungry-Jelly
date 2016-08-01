using UnityEngine;
using System.Collections;

public class Health_Level : MonoBehaviour {

	public static int health = 3;
	public static int level = 1;

	void Start () {
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
