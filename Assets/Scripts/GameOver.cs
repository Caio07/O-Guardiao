using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public float buttonw;
	public float buttonh;


	void Start () {
	
		buttonh = 50f;
		buttonw = 200f;
	}
	


	void OnGUI(){


		if(GUI.Button(new Rect(Screen.width/6,Screen.height / 2 , buttonw, buttonh), "Reiniciar")){
			
			Application.LoadLevel("Jogo");
			
		}

	
		if(GUI.Button(new Rect(Screen.width/2 + 30,Screen.height / 2, buttonw, buttonh), "Voltar ao menu")){
			
			
			Application.LoadLevel("Escolha_personagem");
			
			
		}



	}
}
