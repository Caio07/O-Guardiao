using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public bool CanPause;
	public GUIStyle fundopause;
	public GUIStyle fundoplay;
	public float buttonw;
	public float buttonh;
	public float buttonposition;
	public float buttonPos2;
	public float buttonPos3;


	void Start () {
		CanPause = true;
		buttonh = 50f;
		buttonw = 200f;
		buttonposition = Screen.height/4;
		buttonPos2 = buttonh + buttonposition *1.2f;
		buttonPos3 = buttonh + buttonposition *1.96f;
	}




	void OnGUI()
	{

		CanPause = GUI.Toggle (new Rect (20,30,40,40), CanPause,"",fundopause);

		if (CanPause)
		{

			Time.timeScale = 0;
			CanPause = false;
			renderer.enabled = true;

			GUI.Box(new Rect(0,0,Screen.width,Screen.height),"");
			if(GUI.Button(new Rect((Screen.width - buttonw)*0.5f , buttonposition, buttonw, buttonh), "Tabela de Carboidratos")){
				
				Application.LoadLevel("Tabela_de_carboidratos");

			}
			if(GUI.Button(new Rect((Screen.width - buttonw)*0.5f , buttonPos2, buttonw, buttonh), "Reiniciar")){
				
				Application.LoadLevel("Jogo");
				
			}
			if(GUI.Button(new Rect((Screen.width - buttonw)*0.5f , buttonPos3, buttonw, buttonh), "Voltar ao menu")){
				
				Application.LoadLevel("Escolha_personagem");
				
			}
		}
		else
		{
			Time.timeScale = 1;
			CanPause = true;
			renderer.enabled = false;
		
		}

		/*GUI.skin = imagem;
		if (GUI.Button(new Rect (20,30,40,40), ""))
		{

			if (CanPause)
			{
		
				Application.load("Menu_Pause");
				Time.timeScale = 0;
				CanPause = false;
				renderer.enabled = true;

			}

				
			else
			{
				Time.timeScale=1;
				CanPause = true;
				renderer.enabled = false;
			
			}
		}*/
	
	}
}
