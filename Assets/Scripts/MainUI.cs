using UnityEngine;
using System.Collections;

public class MainUI : MonoBehaviour {

	public GUIStyle btnJogar;
	public float width;
	public float height;
	// Use this for initialization
	void Start () {
	
		width = Screen.width/3;
		height = Screen.width / 10;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {

		
		GUI.Button (new Rect (Screen.width / 3, Screen.height / 2, width, height), "", btnJogar);
			

			
			
		
}
}