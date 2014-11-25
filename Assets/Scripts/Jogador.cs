using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {


	public float distance = 10;
	public Font fonte;
	public GameObject LifeBar;
	public AudioClip clipAudio;

	private Vector3 position;
	
	public float posX;
	public float posY;





	void Start () {


	




}
	    

	void Update () 
{
		Plataforma ();
		Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
		Vector2 pos = r.GetPoint(distance);
		transform.position = pos;
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
			Pontuar("-57");
			GameManager.QntVida -=57f;
			}


				
			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);

			}

		else if(collisor.tag == "Insulina"){

		
			if ( GameManager.QntVida >10)
			{

				Pontuar("-70");
				GameManager.QntVida -= 70f;
			


				
			}

			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);

			}

		else if(collisor.tag == "Abacate"){


			if (GameManager.QntVida >10)
			{

				Pontuar("-30");
				GameManager.QntVida -= 30f;


							}

			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);


			}

		else if(collisor.tag == "Sorvete"){
	
			
			if (GameManager.QntVida<GameManager.MaxQntVida)
			{

				Pontuar("+57");
				GameManager.QntVida += 57f;
		
			}
			
			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);
		}

		else if(collisor.tag == "Cenoura"){
			

			if (GameManager.QntVida<GameManager.MaxQntVida)
			{
				Pontuar("+35");
				GameManager.QntVida += 35f;
				
			}

			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);
			
		}

		else if(collisor.tag == "Pao"){
			
						
			if (GameManager.QntVida<GameManager.MaxQntVida)
			{
				Pontuar("+95");
				GameManager.QntVida += 95f;

			}

			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);
			
		}

		else if(collisor.tag == "Refrigerante"){
			
					
			if (GameManager.QntVida<GameManager.MaxQntVida)
			{

				Pontuar("+63");
				GameManager.QntVida += 63f;


				
			}

			collisor.GetComponent<Acao>().Destroy();
			Audio(clipAudio);
			
			
		}
	}

	void Audio(AudioClip clip){

		audio.clip = clip;
		AudioSource.PlayClipAtPoint(clip, transform.position, 0.2f);
	}

	void LoadLevel() {

		Application.LoadLevel("Game Over");
	}




	void Pontuar(string qntPontos){

		
		GameObject texto = new GameObject("Pontuou");
		Instantiate(texto);
		GUIText myText = texto.AddComponent<GUIText>();
		myText.transform.position = new Vector3(0.5f,0.5f,0f);


		myText.guiText.font= fonte;
		myText.guiText.text = qntPontos;
		myText.guiText.fontSize = 40;
		iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );
		Destroy(texto,1);
	}


}


