using UnityEngine;
using System.Collections;

public class MotionTrigger : MonoBehaviour {

	private MotionBlur mBlur;
	// Use this for initialization
	void Start () {
	
		mBlur = GameObject.Find("Main Camera").GetComponent(MotionBlur);
		mBlur.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
