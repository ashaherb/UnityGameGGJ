using UnityEngine;
using System.Collections;

public class DestroyBasic : MonoBehaviour
{
	public GameObject background;
	void Update ()
	{
		if(this.transform.position.y < -4.5)
		{
			Instantiate(background);
			Destroy(this);
		}
	}
}
