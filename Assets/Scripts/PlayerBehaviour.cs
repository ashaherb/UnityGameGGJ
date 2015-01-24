using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour {

	Text txt;
	static int horizontalBlocks = 4;
	static int verticalBlocks = 5;
	private int currentscore=0;
	// Use this for initialization
	void Start () {	
		txt = gameObject.GetComponent<Text>();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			currentscore++;
			txt.text="Score : " + currentscore;
			float hcoordinates = (int)( (Input.mousePosition.x/Screen.width) / (1/(float)horizontalBlocks) );
			float vcoordinates = (int)( (Input.mousePosition.y/Screen.height) / (1/(float)verticalBlocks) );
			
			//print ("Block : (" + hcoordinates + " , " + vcoordinates + ")");
		}
	}
}
