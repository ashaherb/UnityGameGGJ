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

			float hblock = UpdateBlock(Input.mousePosition.x , 0);
			float vblock = UpdateBlock(Input.mousePosition.y , 1);

			bool isValid = isValidMove(hblock,vblock);
			if (isValid){
				currentscore++;
				print(currentscore);
				txt.text="Score : " + currentscore;

				float xcoor = Screen.width / (horizontalBlocks*2) + (Screen.width/horizontalBlocks) * (hblock - 2);
				if (hblock == 3)xcoor += 25;
				else if(hblock==0)xcoor-=25;
				float ycoor = Screen.height / (verticalBlocks*4) + (Screen.height/verticalBlocks) * (vblock - 2.5F);
				CharMove(xcoor,ycoor);
			}
			else{
				GameOver();
			}
		}
		if (elemChar.transform.position.y < (Screen.height / 2) * (-1)) {
			GameOver();
		}
	}
	int UpdateBlock(float in1 , int sel){
		if (sel == 0)
			return (int)((in1 / Screen.width) / (1 / (float)horizontalBlocks));
		return (int)( (in1/Screen.height) / (1/(float)verticalBlocks) );
	}
	bool isValidMove(float hblock , float vblock){
		float adjustedX = elemChar.transform.position.x + Screen.width / 2.0F;
		float adjustedY = elemChar.transform.position.y + Screen.height / 2.0F;
		float currenthblock = UpdateBlock(adjustedX , 0);
		float currentvblock = UpdateBlock(adjustedY , 1);
		int activeState = PlayerPrefs.GetInt("ActiveAnimal");
		switch (activeState) {
			case 0:{
				if (hblock - currenthblock == 0 && vblock - currentvblock == 2 )
					return true;
				break;
			}
			case 1:{
				if (Mathf.Abs(hblock - currenthblock) == 1 && vblock - currentvblock == 1 )
					return true;
				break;
			}
			case 2:{
				if (Mathf.Abs(hblock - currenthblock) == 1 && vblock - currentvblock == 2 )
					return true;
				break;
			}
			case 3:{
				if (hblock - currenthblock == 0 && vblock - currentvblock == 1 )
					return true;
				break;
			}
		}
		return false;
	}
	void CharMove(float xcoor , float ycoor){

		Vector3 endMarker = new Vector3(xcoor,ycoor,0);
		iTween.MoveTo(elemChar,endMarker,0.25F);
		elemChar.audio.Play ();
	}
	void GameOver(){
		int highscore = PlayerPrefs.GetInt("HighScore");
		if (currentscore > highscore) {
			PlayerPrefs.SetInt("HighScore" , currentscore);
		}
		PlayerPrefs.SetInt("LatestScore" , currentscore);
		Application.LoadLevel("GameOver");
	}
}
