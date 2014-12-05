using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

		public float speed = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

				transform.Translate( Vector3.forward * speed, Space.Self );
				rigidbody2D.AddForce (transform.up * speed);


	}
}
