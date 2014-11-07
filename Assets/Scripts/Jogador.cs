using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {




	public GameObject LifeBar;
	public AudioClip clipAudio;

	private Vector3 position;
	
	public float posX;
	public float posY;

	TrailRenderer trail;



	void Start () {



		trail = this.GetComponent<TrailRenderer> () as TrailRenderer;
		trail.sortingLayerName = "foreground";



}
	    

	void Update () 
{
		Plataforma ();
	
}


	private void Plataforma()
	{
		
		
		if(Application.platform == RuntimePlatform.Android)
		{
			
			if(Input.touchCount == 1)
			{
				position = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, 
				                                                      Input.GetTouch(0).position.y,1));
				
				transform.position = new Vector2(position.x, position.y);
				collider2D.enabled = true;
				return;
			}
			collider2D.enabled = false;
		}
		else 
		{
			
			position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 
			                                                      Input.mousePosition.y,0));
			
			transform.position = new Vector2(position.x, position.y);
		}
		
	}


	public void OnTriggerEnter2D(Collider2D collisor)
	{
		// Colisao de todos os elementos que aparecerao em cena



		if ( collisor.tag == "Exercicio"){

		

			if (GameManager.QntVida >10)
			{
			Pontuar();
			GameManager.QntVida -=57f;
			}


				
			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);

			}/*

		else if(collisor.tag == "Insulina"){

		
			if ( _gameManager.QntVida < _gameManager.MaxQntVida)
			{
				_gameManager.QntVida -= 70f;


				GameObject texto = new GameObject("Pontuou");
				Instantiate(texto);
				GUIText myText = texto.AddComponent<GUIText>();
				myText.transform.position = new Vector3(0.5f,0.5f,0f);
				myText.guiText.text = "-70";
				myText.guiText.fontSize = 24;
				iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );
				
			}

			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);

			}

		else if(collisor.tag == "Abacate"){


			if (QntVida<MaxQntVida)
			{
				QntVida = QntVida - 30f;


				GameObject texto = new GameObject("Pontuou");
				Instantiate(texto);
				GUIText myText = texto.AddComponent<GUIText>();
				myText.transform.position = new Vector3(0.5f,0.5f,0f);
				myText.guiText.text = "-30";
				myText.guiText.fontSize = 24;
				iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );
			}

			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);


			}

		else if(collisor.tag == "Sorvete"){
	
			
			if (QntVida<MaxQntVida)
			{
				QntVida = QntVida + 57f;
		
				GameObject texto = new GameObject("Pontuou");
				Instantiate(texto);
				GUIText myText = texto.AddComponent<GUIText>();
				myText.transform.position = new Vector3(0.5f,0.5f,0f);
				myText.guiText.text = "+57";
				myText.guiText.fontSize = 24;
				iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );
			}
			
			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);
		}

		else if(collisor.tag == "Cenoura"){
			

			if (QntVida<MaxQntVida)
			{
				QntVida = QntVida + 35f;
		
				GameObject texto = new GameObject("Pontuou");
				Instantiate(texto);
				GUIText myText = texto.AddComponent<GUIText>();
				myText.transform.position = new Vector3(0.5f,0.5f,0f);
				myText.guiText.text = "+35";
				myText.guiText.fontSize = 24;
				iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );
				
			}

			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);
			
		}

		else if(collisor.tag == "Pao"){
			
						
			if (QntVida<MaxQntVida)
			{
				QntVida = QntVida + 95f;

				GameObject texto = new GameObject("Pontuou");
				Instantiate(texto);
				GUIText myText = texto.AddComponent<GUIText>();
				myText.transform.position = new Vector3(0.5f,0.5f,0f);
				myText.guiText.text = "+95";
				myText.guiText.fontSize = 24;
				iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );

			}

			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);
			
		}

		else if(collisor.tag == "Refrigerante"){
			
					
			if (QntVida<MaxQntVida)
			{
				QntVida = QntVida + 63f;


				GameObject texto = new GameObject("Pontuou");
				Instantiate(texto);
				GUIText myText = texto.AddComponent<GUIText>();
				myText.transform.position = new Vector3(0.5f,0.5f,0f);
				myText.guiText.text = "+63";
				myText.guiText.fontSize = 24;
				iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );

				
			}

			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);
			
			
		}*/
	}

	void Audio(AudioClip clip){

		audio.clip = clip;
		AudioSource.PlayClipAtPoint(clip, transform.position, 0.2f);
	}

	void LoadLevel() {

		Application.LoadLevel("Game Over");
	}




	void Pontuar(){

		
		GameObject texto = new GameObject("Pontuou");
		Instantiate(texto);
		GUIText myText = texto.AddComponent<GUIText>();
		myText.transform.position = new Vector3(0.5f,0.5f,0f);
		
		myText.guiText.text = "-50";
		myText.guiText.fontSize = 24;
		iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );
		myText.guiText.text = "-30";
		Destroy(texto,1);
	}


}


