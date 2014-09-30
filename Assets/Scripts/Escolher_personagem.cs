using UnityEngine;
using System.Collections;

public class Escolher_personagem : MonoBehaviour {
	
	public float topBannerH;
	public float topBannerW;
	//Buttons
	public float  buttonSizeH;
	public float  buttonSizeW;
	public float  buttonPos1;
	public float  buttonPos2;
	public float  buttonPos3;
	public float  buttonPos4;
	public float  buttonPos5;
	//Bottom Banner
	public float  bottomBannerH;
	public float  bottomBannerW;
	public float  bottomBannerPos;
	public string exampleVar1;
	public GUISkin customSkin1;
	public GUISkin customSkin2;
	public GUISkin customSkin3;
	timer iniciar = new timer();
	
	void Awake () {
		topBannerH = Screen.height/4;
		topBannerW = Screen.width;
		buttonSizeH = Screen.height/10;
		buttonSizeW = Screen.width;
		buttonPos1 = topBannerH;
		buttonPos2 = topBannerH+buttonSizeH;
		buttonPos3 = topBannerH+buttonSizeH*2;
		buttonPos4 = topBannerH+buttonSizeH*3;
		buttonPos5 = topBannerH+buttonSizeH*4;
		bottomBannerH = Screen.height/4;
		bottomBannerW =  Screen.width;
		bottomBannerPos = topBannerH+buttonSizeH*5;	
	}
	
	void OnGUI() {
		GUI.skin = customSkin1;
		//Title Banner
		GUI.Box(new Rect(0,0,topBannerW,topBannerH),exampleVar1);
		
		GUI.skin = customSkin2;
		//Button 1
		if (GUI.Button(new Rect(0,buttonPos1,buttonSizeW,buttonSizeH),"Ir para o jogo")){
			Application.LoadLevel(2);
		
		}
	
		
		
		GUI.skin = customSkin3;
		//Bottom Banner
		GUI.Box(new Rect(0,bottomBannerPos,bottomBannerW,bottomBannerH),"we can place advertisements, links\nwhatever we want here.");
	}

}
