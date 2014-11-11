using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	private float buttonw;
	private float buttonh;
	public GUIStyle btnReiniciar;
	public GameObject finalScoretext;


	private GameManager _gameManager;

	void Start () {
	

		buttonh = 50f;
		buttonw = 200f;
		finalScoretext.guiText.text = "Pontuaçao Final:\n" + Pontuacao.pontos;

	}
	


	void OnGUI(){


		if(GUI.Button(new Rect(Screen.width/2 -100,Screen.height -100 , buttonw, buttonh),"", btnReiniciar)){

		
			Application.LoadLevel("Jogo");		
		

		}


	}
	/*public void Recorde(){
		
		if( Pontuacao.pontos > PlayerPrefs.GetInt("Recorde")){
			recorde = (int) Pontuacao.pontos;
			PlayerPrefs.SetInt("Recorde", recorde);
			
		}
		if(recorde != null){
			
			gRecorde.guiText.text = "Recorde:" + " " + 
				PlayerPrefs.GetInt("Recorde").ToString();
		}
		
	}*/
}
