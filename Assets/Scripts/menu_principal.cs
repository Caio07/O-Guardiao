using UnityEngine;
using System.Collections;

public class menu_principal : MonoBehaviour {


	public float buttonw;
	public float buttonh;
	public float buttonposition;
	public float buttonPos2;
	public float buttonPos3;
	public bool  showWindowI;
	public bool  showWindowC;
	public Rect windowRect;
	public GameObject _logo;

	
void Awake () {
		buttonh = 50f;
		buttonw = 200f;
		buttonposition = Screen.height/4;
		buttonPos2 = buttonh + buttonposition *1.2f;
		buttonPos3 = buttonh + buttonposition *1.96f;
		showWindowI = false;
		showWindowC = false;
		windowRect = new Rect(0,0, Screen.width, Screen.height);

		
		_logo = Instantiate (_logo.transform, 
		                     _logo.transform.position, 
		                     _logo.transform.rotation) as GameObject;
	}
	
	void OnGUI() {
	
		if(showWindowI){
			
			windowRect = GUI.Window(0, windowRect, DoMyWindowI, "Instruções");	
		}

		
		if(showWindowC){
			
			windowRect = GUI.Window(0, windowRect, DoMyWindowC, "Creditos");	
		}

		if(GUI.Button(new Rect(Screen.width - 250,Screen.height / 2 - 65, buttonw, buttonh), "Jogar")){
			
			Application.LoadLevel(1);
			
		}
		if(GUI.Button(new Rect(Screen.width - 250,Screen.height / 2, buttonw, buttonh), "Instruções")){


			showWindowI = true;

				
			}
			

		if(GUI.Button(new Rect(Screen.width - 250,Screen.height / 2 + 65, buttonw, buttonh), "Créditos")){
			
			showWindowC = true;
			
		}
	}
	
	void DoMyWindowI(int windowID) {

		GUILayout.Label("Para jogar, acerte os itens que aparecem na tela através do touch do celular e " +
			"equilibre sua glicose pelo maior tempo possível!");
		if (GUI.Button (new Rect (Screen.width - 50, 0, 40, 20), "X")) {
						showWindowC = false;
						showWindowI = false;
				}
	}
	void DoMyWindowC(int windowID) {
		
		GUILayout.Label("Aqui irão os créditos.");
		if (GUI.Button (new Rect (Screen.width - 50, 0, 40, 20), "X")) {
			showWindowC = false;
			showWindowI = false;
		}
	}
}
