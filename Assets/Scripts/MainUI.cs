using UnityEngine;
using System.Collections;

public class MainUI : MonoBehaviour {

	public GUIStyle btnJogar;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {

		
		GUI.Button (new Rect (Screen.width / 3, Screen.height / 2, 200F, 50F), "", btnJogar);
			

			
			
		
}
}