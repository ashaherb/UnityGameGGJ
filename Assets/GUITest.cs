using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour {
	
	void OnGUI () {

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(30,130,80,23), "Play")) {
			Application.LoadLevel(1);
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(30,160,120,23), "How To Play")) {
			Application.LoadLevel(1);
		}
		// Make the second button.
		if(GUI.Button(new Rect(30,190,120,23), "High Score")) {
			Application.LoadLevel(1);
		}
	}
}