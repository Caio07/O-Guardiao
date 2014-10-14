using UnityEngine;
using System.Collections;

public class staticText : MonoBehaviour {


	public static string text;
	float duration = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = text;

		if(Time.time > duration){
			Destroy(gameObject);
				}

	
	}
	void fadeOut(){

		
		Color myColor = guiText.color;
		float ratio = 3;
		myColor.a = Mathf.Lerp (1, 0, ratio);
		guiText.color = myColor;
	}

}
