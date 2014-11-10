using UnityEngine;
using System.Collections;

public class Pontuacao : MonoBehaviour {


	//private int recorde;

	public float pontos;
	public float speed;

	public float timeRemaining;
	public float startTime;

	// Use this for initialization
	void Start () {
	
		pontos = 0;
		speed = 3F;

		//Recorde();

	}
	void Update(){

	
		pontos =(int)Time.timeSinceLevelLoad % 60 * speed;
		guiText.text = pontos.ToString();

	}

	public void Hit(float multiplicador){
		
		pontos *= multiplicador;		
		
	}


	/*public void Recorde(){

		if( pontos > PlayerPrefs.GetInt("Recorde")){

			PlayerPrefs.SetInt("Recorde", pontos);

		}
		if(textPontos != null){

			textPontos.guiText.text = "Recorde:" + " " + 
				PlayerPrefs.GetInt("Recorde").ToString();
		}

	}*/
}
