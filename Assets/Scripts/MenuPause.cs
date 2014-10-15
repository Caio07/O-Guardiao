using UnityEngine;
using System.Collections;

public class MenuPause : MonoBehaviour {

	public float topBannerH;
	public float topBannerW;
	//Buttons
	public float  buttonSizeH;
	public float  buttonSizeW;
	public float  buttonPos1;
	public float  buttonPos2;

	public GUISkin customSkin2;

	
	void Awake () {
		topBannerH = Screen.height/2;
		topBannerW = Screen.width;
		buttonSizeH = Screen.height/10;
		buttonSizeW = Screen.width/2;
		buttonPos2 = topBannerH+buttonSizeH;

	}
	
	void OnGUI() {

		

		//Button 1
		if (GUI.Button(new Rect(Screen.width/4 ,topBannerH,buttonSizeW,buttonSizeH),"Voltar ao Jogo")){

		

			
		}
		//Button 2
		if (GUI.Button(new Rect(Screen.width/4,buttonPos2,buttonSizeW,buttonSizeH),"Reiniciar")){
			//int previousLevel = PlayerPrefs.GetInt( "previousLevel" );
			Application.LoadLevel( "Jogo" );
		}

		
		
	
	}
}
