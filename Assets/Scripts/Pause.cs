using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public bool CanPause;
	public GUIStyle imagem;





	void Start () {
		CanPause = false;


	}




	void OnGUI()
	{

		CanPause = GUI.Toggle (new Rect (20,30,40,40), CanPause,"",imagem);
		if (CanPause)
		{
			Time.timeScale = 0;
			CanPause = false;
			renderer.enabled = true;
			if(GUI.Button(new Rect(40,30,40,40),"botao")){

				Application.LoadLevel(1);
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
