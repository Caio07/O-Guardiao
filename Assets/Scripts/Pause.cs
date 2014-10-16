using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public bool CanPause;
	public GUIStyle fundopause;
	public GUIStyle fundoplay;





	void Start () {
		CanPause = true;
	


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
			if(GUI.Button(new Rect(Screen.width / 2, Screen.height /2,200,200), "Tabela de Carboidratos")){
				
				Application.LoadLevel("Tabela_de_carboidratos");

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
