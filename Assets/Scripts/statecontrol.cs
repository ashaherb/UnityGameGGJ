using UnityEngine;
using System.Collections;

public class statecontrol : MonoBehaviour {


	ArrayList states = new ArrayList ();

	// Use this for initialization
	void Start () {


		states.Add((SpriteRenderer)GameObject.FindWithTag ("camalactive").GetComponents<SpriteRenderer> ()[0]);
		states.Add((SpriteRenderer)GameObject.FindWithTag ("lionactive").GetComponents<SpriteRenderer> ()[0]);
		states.Add((SpriteRenderer)GameObject.FindWithTag ("horseactive").GetComponents<SpriteRenderer> ()[0]);
		states.Add((SpriteRenderer)GameObject.FindWithTag ("elephantactive").GetComponents<SpriteRenderer> ()[0]);

		StartCoroutine (ChangeState());
	}

	IEnumerator ChangeState()
	{
		while (true) {
						int rand = Random.Range (0, states.Count);
		
						SpriteRenderer s = (SpriteRenderer)states [rand];
						s.sortingOrder = 21;
		
						for (int i = 0; i < states.Count; i++) {
								s = (SpriteRenderer)states [i];
								if (i != rand)
										s.sortingOrder = 0;
						}

						yield return new WaitForSeconds (5);
				}
	}

	void FixedUpdate()
	{


	}

	// Update is called once per frame
	void Update () {
	



	}
}
