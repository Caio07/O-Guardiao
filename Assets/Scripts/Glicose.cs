using UnityEngine;
using System.Collections;

public class Glicose : MonoBehaviour {

	public GUISkin textbutton;
	public GUISkin textbox;



	public float posX;
	public float posY;
	public float height;
	public float width;
	public float height2;

	public float QntVida;
	public float MaxQntVida;


	public float tempo;

	// Use this for initialization
	void Start () {

		QntVida=70f;
		MaxQntVida=100f;


	}
	
	// Update is called once per frame
	void Update () {
	

		width = Screen.width/15;
		posX = 550;
		posY = Screen.height/4;
		height = Screen.height/1.4f;
		height2 = Screen.height/1.4f * (QntVida/MaxQntVida);
	}
	
	void OnGUI()
	{

		GUI.skin = textbox;


		GUI.Button(new Rect(posX,posY,width,height2)," ");


			GUI.Box(new Rect(posX,posY,width,height)," ");
			
		/*
		if (QntVida>0)
		{
			QntVida = QntVida - 0.5f;
			tempo = -1;
		}
			
		if (tempo>=0)
		{
			if (QntVida<100)
			{
				if (tempo>0.01f)
				{
					QntVida = QntVida+0.5f;
					tempo = 0;
				}
			}
			
			
			
		}
		
		
		tempo=tempo+Time.deltaTime;

	
	}*/


	}


}
