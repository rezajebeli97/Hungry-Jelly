using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class Menu : MonoBehaviour {

	public Text highScore;
	public Button startText;
	public Button exitText;


	void Start () {
//		startText = startText.GetComponent<Button> ();
//		exitText = exitText.GetComponent<Button> ();

		if (File.Exists (Application.dataPath + "/highScore.json")) {
			string savedHighScoreStr = File.ReadAllText (Application.dataPath + "/highScore.json");
			highScore.text = "HighScore : " + savedHighScoreStr;
		}
	}
		
	public void StartLevel(){
		Application.LoadLevel (1);
	}

	public void ExitGame(){
		Application.Quit ();
	}

}
