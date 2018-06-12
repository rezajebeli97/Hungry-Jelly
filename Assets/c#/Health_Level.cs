using UnityEngine;
using System.Collections;


public class Health_Level : MonoBehaviour {

	public static int health = 3,level = 1,score=0;


	void Start () {
		DontDestroyOnLoad (this);
		//scoreJson = JsonMapper.ToJson (score);

	}
	
	// Update is called once per frame
}
