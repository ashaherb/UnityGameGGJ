using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour {

	Text txt;
	private GameObject elemChar;
	static int horizontalBlocks = 4;
	static int verticalBlocks = 5;
	private int currentscore=0;
	// Use this for initialization
	void Start () {	
		txt = gameObject.GetComponent<Text>();
		elemChar = GameObject.Find("character");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			currentscore++;
			txt.text="Score : " + currentscore;
			float hblock = (int)( (Input.mousePosition.x/Screen.width) / (1/(float)horizontalBlocks) );
			float vblock = (int)( (Input.mousePosition.y/Screen.height) / (1/(float)verticalBlocks) );
			
			float xcoor = Screen.width / (horizontalBlocks*2) + (Screen.width/horizontalBlocks) * (hblock - 2);
			if (hblock == 3)xcoor += 25;
			else if(hblock==0)xcoor-=25;
			float ycoor = Screen.height / (verticalBlocks*4) + (Screen.height/verticalBlocks) * (vblock - 2.5F);
			print (Screen.width);
			print (xcoor + " - " + ycoor);
			CharMove(xcoor,ycoor);
		}
		if (elemChar.transform.position.y < (Screen.height/2)*(-1)) {
			print("Halleloya");
		}else
			print (elemChar.transform.position.y);
	}
	void CharMove(float xcoor , float ycoor){

		Vector3 endMarker = new Vector3(xcoor,ycoor,0);
		iTween.MoveTo(elemChar,endMarker,1);
		elemChar.audio.Play ();
	}
}
