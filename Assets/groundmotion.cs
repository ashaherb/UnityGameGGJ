﻿using UnityEngine;
using System.Collections;

public class groundmotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () { 
		transform.Translate(new Vector3 (0f,- 1.2f, 0));
	}
}
