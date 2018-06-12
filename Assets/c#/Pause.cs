using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public Canvas canvas;
	public Button pause,play,home;

	void Start () {
		canvas = canvas.GetComponent<Canvas> ();
		pause = pause.GetComponent<Button> ();
		play = play.GetComponent<Button> ();
		home = home.GetComponent<Button> ();
		canvas.enabled = false;
	}
	
	public void PausePress(){
		canvas.enabled = true;
	}

	public void PlayPress(){
		canvas.enabled = false;
	}

	public void HomePress(){
		Health_Level.level = 1;
		Health_Level.health = 3;
		Health_Level.score = 0;
		Application.LoadLevel (0);
	}
}
