using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour {

	Text txt;
	private GameObject elemScore;
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
			float hblock = (int)( (Input.mousePosition.x/Screen.width) / (1/(float)horizontalBlocks) );
			float vblock = (int)( (Input.mousePosition.y/Screen.height) / (1/(float)verticalBlocks) );
			
			float xcoor = Screen.width / (horizontalBlocks*2) + (Screen.width/horizontalBlocks) * (hblock - 2);
			float ycoor = Screen.height / (verticalBlocks*2) + (Screen.height/verticalBlocks) * (vblock - 2);

			CharMove(xcoor,ycoor);
		}
	}
	void CharMove(float xcoor , float ycoor){
		elemScore = GameObject.Find("character");
		Vector3 endMarker = new Vector3(xcoor,ycoor,0);
		iTween.MoveTo(elemScore,endMarker,1);
	}
}
