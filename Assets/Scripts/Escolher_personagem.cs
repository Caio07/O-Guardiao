using UnityEngine;
using System.Collections;

public class Escolher_personagem : MonoBehaviour {
	

	//Buttons
	public float  buttonSizeH;
	public float  buttonSizeW;
	public float  buttonPos1;
	public Texture customSkin2;




	void Awake () {

		buttonSizeH = Screen.height/10;
		buttonSizeW = Screen.width;
		buttonPos1 = 10;


	}
	
	void OnGUI() {
	
		

		//Button 1
		if (GUI.Button(new Rect(0,buttonPos1,123,233),customSkin2)){
			Application.LoadLevel(2);
		
		}
	
		
		

	}

}
