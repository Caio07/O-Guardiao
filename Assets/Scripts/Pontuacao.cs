using UnityEngine;
using System.Collections;

public class Pontuacao : MonoBehaviour {




	public static float pontos;
	public static float speed;


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





}
