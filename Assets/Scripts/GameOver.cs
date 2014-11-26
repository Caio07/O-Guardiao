using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	private float buttonw;
	private float buttonh;
	public GUIStyle btnReiniciar;
	public GameObject finalScoretext;
	public GameObject txtrecorde;



	void Start () {
	

		buttonh = 50f;
		buttonw = 200f;
		finalScoretext.guiText.text = "Pontuaçao Final:\n" + Pontuacao.pontos;
		txtrecorde.guiText.text= "Recorde \n" + PlayerPrefs.GetFloat("Recorde").ToString();

	}

	
	public void Recorde(){
		
		if( Pontuacao.pontos > PlayerPrefs.GetFloat("Recorde"))
		{
			
			PlayerPrefs.SetFloat("Recorde", Pontuacao.pontos);
		}

		
		
	}


	void OnGUI(){


		if(GUI.Button(new Rect(Screen.width/2 -100,Screen.height -100 , buttonw, buttonh),"", btnReiniciar)){

		
			Application.LoadLevel("Jogo");	

		

		}


	}

}
