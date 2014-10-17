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


	void Awake () {

		buttonSizeH = Screen.height/10;
		buttonSizeW = Screen.width;
		posH = Screen.height/4;
		posW = Screen.width /4 - 50;
		posW2 = Screen.width /4 + 50;
		posW3 = Screen.width /4 + 150;
		posW4 = Screen.width /4 + 250;
	}
	
	void OnGUI() {
	

		//Button 1
		if (GUI.Button(new Rect( posW,posH, 123,233),"", customSkin1)){
			Application.LoadLevel(2);
		
		}
	
		if (GUI.Button(new Rect(posW2,posH,123,233),"", customSkin2)){
			Application.LoadLevel(2);
			
		}
		if (GUI.Button(new Rect(posW3,posH,123,233),"", customSkin3)){
			Application.LoadLevel(2);
			
		}
		if (GUI.Button(new Rect(posW4,posH,123,233),"", customSkin4)){
			Application.LoadLevel(2);
			
		}

	}

}
