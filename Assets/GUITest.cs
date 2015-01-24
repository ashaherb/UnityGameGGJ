using UnityEngine;
using System.Collections;

public class GUITest : MonoBehaviour {
	
	void OnGUI () {

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(34,130,80,23), "Play")) {
			Application.LoadLevel(1);
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(30,160,120,30), "How To Play")) {
			Application.LoadLevel(1);
		}
		// Make the second button.
		if(GUI.Button(new Rect(50,200,120,30), "High Score")) {
			Application.LoadLevel(1);
		}
	}
}