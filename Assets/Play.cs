﻿using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
	
	void OnGUI() {
		if(GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 1, 200, 30), "Demooo"))
			Application.LoadLevel(1);
		
	}
}
