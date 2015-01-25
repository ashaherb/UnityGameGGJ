using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameOverBehaviour : MonoBehaviour {

	// Use this for initialization
	private GameObject textGame;
	void Start () {
		textGame = GameObject.Find("GameOver");
		textGame.audio.Play ();

		int latestScore = PlayerPrefs.GetInt("LatestScore");
		int highScore = PlayerPrefs.GetInt("HighScore");
		
		Text textObject1 = GameObject.Find("HighScore").GetComponent<Text>();
		textObject1.text = highScore.ToString();
		Text textObject2 = GameObject.Find("LatestScore").GetComponent<Text>();
		textObject2.text = latestScore.ToString ();

	}
	void OnGUI(){
		if ( GUI.Button(new Rect(Screen.width/2 - 75 , Screen.height - 50 , 150 ,30 ), "New Game")){
			Application.LoadLevel("TheGame");
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
