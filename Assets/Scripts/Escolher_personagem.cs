using UnityEngine;
using System.Collections;

public class Escolher_personagem : MonoBehaviour {
	

	//Buttons
	public float  buttonSizeH;
	public float  buttonSizeW;
	public float  posH;
	public float  posW;
	public float  posW2;
	public float  posW3;
	public float  posW4;
	public GUIStyle customSkin1;
	public GUIStyle customSkin2;
	public GUIStyle customSkin3;
	public GUIStyle customSkin4;
	public bool  showWindow;
	public Rect windowRect;



	void Awake () {

		buttonSizeH = Screen.height/10;
		buttonSizeW = Screen.width;
		posH = Screen.height/2 - (Screen.height/2)/2;
		posW = Screen.width/2 - (Screen.width/10)/2;
		posW2 = Screen.width /4 ;
		posW3 = Screen.width /4 + 150;
		posW4 = Screen.width /4 + 300;
		showWindow = false;
		windowRect = new Rect(0,0, Screen.width, Screen.height);
	}
	
	void OnGUI() {
	
		if(showWindow){
			
			windowRect = GUI.Window(0, windowRect, DoMyWindow, "Nina");	
		}

		if (GUI.Button(new Rect(posW,posH,Screen.width/5,Screen.height/1.5F),"", customSkin2)){
			showWindow = true;


		}

		/*
		if (GUI.Button(new Rect( posW,posH, 123,233),"", customSkin1)){
			Application.LoadLevel(2);
		
		}*/
	

		/*if (GUI.Button(new Rect(posW3,posH,123,233),"", customSkin3)){
			Application.LoadLevel(2);
			
		}
		if (GUI.Button(new Rect(posW4,posH,123,233),"", customSkin4)){
			Application.LoadLevel(2);
			
		}*/

	}
	void DoMyWindow(int windowID) {
		
		GUILayout.Label("Nome: Nina\n" +
		                "Idade: 14 anos\n" +
		                "Historia: lorem Ipsum Dolor Siamet");
		if (GUI.Button (new Rect (Screen.width - 50, 0, 40, 20), "X")) {
			showWindow = false;

		}
		if (GUI.Button (new Rect (Screen.width/4 + 50, Screen.height - 100, 200, 50), "Jogar!")) {
			Application.LoadLevel(2);
			
		}
	}

}
