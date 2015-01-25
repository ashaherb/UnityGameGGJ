using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {
	
	void OnGUI () {
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(Screen.width/2 +20 , Screen.height -30 ,80,23), "Exit")) {
			Application.LoadLevel(0);
		}
		
	}
}