using UnityEngine;
using System.Collections;

public class tester : MonoBehaviour {

	public float scrollSpeed;
	public float tileSizeZ;
	
	private Vector3 startPosition;
	
	void Start ()
	{
		startPosition = transform.position;
	}
	int flag = 0;
	void Update ()
	{
		flag++;
		float newPosition = Mathf.Repeat(flag * scrollSpeed, tileSizeZ);
		transform.position = startPosition + Vector3.up * newPosition;
		//transform.position = Vector3(0 ,  0 , 0);
	}
}