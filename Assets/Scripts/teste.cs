using UnityEngine;
using System.Collections;

public class teste : MonoBehaviour {

	private int buttonWidth = 200;
	private int buttonHeight = 50;
	private int groupWidth = 200;
	private int groupHeight = 170;
	bool paused = false;
	public GUISkin imagem;

	void Start () {
		
		Time.timeScale =  1;
	}

	void OnGUI () {
		GUI.skin = imagem;

		if (GUI.Button(new Rect(20,30,40,40), "")){
			paused = tooglePause();
			/*if(paused){
				
				GUI.BeginGroup(new Rect(((Screen.width/2) - (groupWidth/2)), ((Screen.height/2) - (groupHeight/2)), groupWidth, groupHeight));
				if (GUI.Button(new Rect(0,0,buttonWidth,buttonHeight), "Main Menu"))
				{
					
					//Application.loadedLevel(0);
				}
				if(GUI.Button(new Rect(0,60,buttonWidth,buttonHeight),"Restart Game"))
				{
					//Application.loadedLevel(1);
				}
				if(GUI.Button(new Rect(0,120,buttonWidth,buttonHeight),"Quit Game"))
				{
					//Application.loadedLevel(1);
				}
				GUI.EndGroup();
			}*/

		} 

			
	}

	void Update () {
	

	}

	bool tooglePause()
	{
		if(Time.timeScale ==0)
		{
			Time.timeScale = 1;
			return(false);
		}
		else
		{
			Time.timeScale = 0;
			return(true);
		}
		
	}
	}

