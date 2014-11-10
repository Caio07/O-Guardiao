using UnityEngine;
using System.Collections;

public class MainUI : MonoBehaviour {

	public GUISkin botaoJogar;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUi(){


		GUI.Button(new Rect(0.5F,0.5F, 400,400)," ");
	}
}
