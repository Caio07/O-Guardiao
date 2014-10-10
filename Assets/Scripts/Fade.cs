using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {

	float duration = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > duration){
			Destroy(gameObject);

		}

		Color myColor = guiText.color;
		float ratio = Time.time/duration;
		myColor.a = Mathf.Lerp(1,0, ratio);
		guiText.color = myColor;
	}
}
