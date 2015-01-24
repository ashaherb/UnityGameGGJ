
using UnityEngine;
using System.Collections;

public class NavigationMovement: MonoBehaviour {
	
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		
		agent = GetComponent<NavMeshAgent>();
		
	}
	
	// Update is called once per frame
	void Update () {
		Plane playerPlane = new Plane (Vector3.up, transform.position);
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Input.GetMouseButton(0))
		{
			float hitdist = 0.0f;
			playerPlane.Raycast(ray, out hitdist);
			Vector3 targetPoint = ray.GetPoint(hitdist);
			agent.SetDestination(targetPoint);
		}
	}
}