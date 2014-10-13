using UnityEngine;
using System.Collections;

public class CircleBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float revealOffset = (float)(Time.timeSinceLevelLoad % 10) / 10.1F; 
		
		gameObject.renderer.material.SetFloat ("_Cutoff", revealOffset);
	
	}
}
