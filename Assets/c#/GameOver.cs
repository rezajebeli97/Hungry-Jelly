using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;

public class GameOver : MonoBehaviour {

	public Button startText;
	public Button homeText;
	public Text showScore;

	void Start () {	
		sentToServer (Health_Level.level , Health_Level.score , Health_Level.health , 4002);

		startText = startText.GetComponent<Button> ();
		homeText= homeText.GetComponent<Button> ();
		string savedHighScoreStr;
		int savedHighScoreInt;

		if (File.Exists (Application.dataPath + "/highScore.json")) {
			savedHighScoreStr = File.ReadAllText (Application.dataPath + "/highScore.json");
			savedHighScoreInt = Convert.ToInt32 (savedHighScoreStr);

			if (Health_Level.score > savedHighScoreInt) {
				File.WriteAllText (Application.dataPath + "/highScore.json", Health_Level.score.ToString ());
				showScore.text = "New Record : " + Health_Level.score.ToString ();
			}
			else {
				showScore.text ="score : " + Health_Level.score.ToString ();
			}
				
		}
		else {
			File.WriteAllText (Application.dataPath + "/highScore.json", Health_Level.score.ToString ());
			showScore.text = "New Record : " + Health_Level.score.ToString ();
		}

		Health_Level.level = 1;
		Health_Level.health = 3;
		Health_Level.score = 0;

		sentToServer(Health_Level.level , Health_Level.score , Health_Level.health , 4003);			//SENTOSERVER :D

	}

	public void StartLevel(){
		Application.LoadLevel (Health_Level.level);
	}

	public void HomePress(){
		Application.LoadLevel (0);
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
}
