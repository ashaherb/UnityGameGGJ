using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
	public int score=10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int lastHighScore = PlayerPrefs.GetInt ("HighScore");
		if (lastHighScore < score) {
		PlayerPrefs.SetInt ("HighScore", score);
		}
	}
}
