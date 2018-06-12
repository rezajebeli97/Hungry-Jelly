using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;

public class UserFinished : MonoBehaviour {

	public Button startText;
	public Button homeText;

	void Start () {	
		startText = startText.GetComponent<Button> ();
		homeText= homeText.GetComponent<Button> ();
		string savedHighScoreStr;
		int savedHighScoreInt;


		if (File.Exists (Application.dataPath + "/highScore.json")) {
			savedHighScoreStr = File.ReadAllText (Application.dataPath + "/highScore.json");
			savedHighScoreInt = Convert.ToInt32 (savedHighScoreStr);

			if (Health_Level.score > savedHighScoreInt)
				File.WriteAllText (Application.dataPath + "/highScore.json", Health_Level.score.ToString ());
			}
		else {
			File.WriteAllText (Application.dataPath + "/highScore.json", Health_Level.score.ToString ());
		}

		Health_Level.level = 1;
		Health_Level.health = 3;
		Health_Level.score = 0;

	}
	
	public void StartLevel(){
		Application.LoadLevel (Health_Level.level);
	}

	public void HomePress(){
		Application.LoadLevel (0);
	}
}
