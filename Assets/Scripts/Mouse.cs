using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {

	public float distance = 10;
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
		Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
		Vector2 pos = r.GetPoint(distance);
		transform.position = pos;

	}
}
