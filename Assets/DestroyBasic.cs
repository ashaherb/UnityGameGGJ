using UnityEngine;
using System.Collections;

public class DestroyBasic : MonoBehaviour
{
	public GameObject Stone;
	void Update ()
	{
		if(this.transform.position.y <-484.5)
		{
			Instantiate(this,new Vector3(-3.2f,506f,10f),Quaternion.identity);
			Destroy(this);
		}
	}
}
