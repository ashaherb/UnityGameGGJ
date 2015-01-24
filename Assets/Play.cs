using UnityEngine;
using System.Collections;

public class MainMenuGUIScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI() {
		GUILayout.BeginArea( new Rect( Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200) );
		GUILayout.FlexibleSpace();
		
		if( GUILayout.Button("Button") ) {
			Button();
		}
		
		
		
		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
	}
	
	void Button() {
		Application.LoadLevel("level1s");
	}
	
}
