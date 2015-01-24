using UnityEngine;
using System.Collections;

public class GameBehaviour : MonoBehaviour {

	//private GameObject elemScore;
	// Use this for initialization
	void Start () {
		/*elemScore = GameObject.Find("guiScore");*/
	}
	void OnGUI() {
		GUILayout.BeginArea( new Rect( Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200) );
		GUILayout.FlexibleSpace();

		Screen.orientation = ScreenOrientation.Portrait;

		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
