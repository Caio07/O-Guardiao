using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	
	public GUIStyle btnReiniciar;
	public GameObject finalScoretext;
	public GameObject txtrecorde;



	void Start () {
	

		
		finalScoretext.guiText.text = "Pontuaçao Final:\n" + Pontuacao.pontos;
		txtrecorde.guiText.text= "Recorde \n" + PlayerPrefs.GetFloat("Recorde").ToString();

	}

	
	public void Recorde(){
		
		if( Pontuacao.pontos > PlayerPrefs.GetFloat("Recorde"))
		{
			
			PlayerPrefs.SetFloat("Recorde", Pontuacao.pontos);
		}

		
		
	}


	


	

}
