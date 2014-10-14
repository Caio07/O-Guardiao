using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {



	float rotationAngle = 180;
	public GameObject personagem;
	public GameObject teste_pontos;
	private Vector3 position;
<<<<<<< HEAD
	//private Vector3 psposition;
=======
	private Vector3 psposition;
>>>>>>> origin/master
	public GUISkin textbox;
	public float posX;
	public float posY;
	public float height;
	public float width;
	public float width2;
	public float height2;
	public float QntVida;
	public float MaxQntVida;
	private float initializationTime;



	public Texture2D fundomax;
	public Texture2D fundomin;
	public Texture2D fundobom;
	

	public AudioClip clipAudio;


	TrailRenderer trail;


	// Use this for initialization
	void Start () {

<<<<<<< HEAD

		/*Vector2 psposition = personagem.transform.position;

		psposition.x = 7.35f;
		psposition.y = 3.54f;*/
=======
		initializationTime = Time.realtimeSinceStartup;
		Vector2 psposition = personagem.transform.position;

		psposition.x = Screen.width / 70;
		psposition.y = Screen.height/ 85 + 0.5f;
>>>>>>> origin/master

		QntVida=100;
		MaxQntVida=300;
		renderer.enabled = true;

		/*GameObject clone;
		clone = Instantiate(personagem.transform, 
		                    personagem.transform.position, 
		                    personagem.transform.rotation) as GameObject;
<<<<<<< HEAD
		personagem.transform.position = psposition;*/
=======
		personagem.transform.position = psposition;
>>>>>>> origin/master
	
				  }
	    
	
	// Update is called once per frame
	void Update () 
{

	
		if(renderer.enabled)
		{
			
			Time.timeScale = 0;
			
        }

		bool tapTouch = Input.GetMouseButtonDown(0);

		if(tapTouch)
		{
			renderer.enabled = false;
			Time.timeScale =1;


		}


		Plataforma ();
		width = Screen.width/13;
		posX = Screen.width - width;
		posY = Screen.height/4;
		height = Screen.height/1.4f;
		height2 = Screen.height/1.4f * (QntVida/MaxQntVida);

		if(renderer.enabled == false){
			if( QntVida < MaxQntVida)
			{
			QntVida -= 0.1f;
		
			
			}}

		if(QntVida<=50)
		{
			Handheld.Vibrate();
			collider2D.enabled = false;
			QntVida += 5;
			Invoke("LoadLevel", 1f);
		}



		if(QntVida > 270)
		{
			collider2D.enabled = false;
			Invoke("LoadLevel", 1f);

		}



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

			if (QntVida>10)
			{
				QntVida = QntVida - 57f;
				//staticText.text = "+30";

<<<<<<< HEAD

=======
				float timeSinceInitialization = Time.realtimeSinceStartup - initializationTime;
>>>>>>> origin/master
				GameObject texto = new GameObject("Pontuou");
				Instantiate(texto);
				GUIText myText = texto.AddComponent<GUIText>();
				myText.transform.position = new Vector3(0.5f,0.5f,0f);
<<<<<<< HEAD
				myText.guiText.text = "-50";
				myText.guiText.fontSize = 24;
				iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );
=======
				myText.guiText.text = "-30";
				Destroy(texto,1);
>>>>>>> origin/master

				
		


			}

				
			collisor.GetComponent<Acao>().Destroy();


			Audio(clipAudio);
			}
		else if(collisor.tag == "Insulina"){

			Audio(clipAudio);
			collisor.GetComponent<Acao>().Destroy();
		
			if (QntVida<MaxQntVida)
			{
				QntVida = QntVida - 70f;


				GameObject texto = new GameObject("Pontuou");
				Instantiate(texto);
				GUIText myText = texto.AddComponent<GUIText>();
				myText.transform.position = new Vector3(0.5f,0.5f,0f);
				myText.guiText.text = "-70";
				myText.guiText.fontSize = 24;
				iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );
				
			}

			/*if(!vidas.Remover()){

				collider2D.enabled = false;
				Invoke("LoadLevel", 1f);
				//pontos.Recorde ();


			}*/
			}
		else if(collisor.tag == "Abacate"){

			Audio(clipAudio);
			collisor.GetComponent<Acao>().Destroy();
		
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


			}

		else if(collisor.tag == "Sorvete"){
			
			Audio(clipAudio);
			collisor.GetComponent<Acao>().Destroy();
			
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
			
			
		}

		else if(collisor.tag == "Cenoura"){
			
			Audio(clipAudio);
			collisor.GetComponent<Acao>().Destroy();
			
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
			
			
		}

		else if(collisor.tag == "Pao"){
			
			Audio(clipAudio);
			collisor.GetComponent<Acao>().Destroy();
			
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
			
			
		}

		else if(collisor.tag == "Refrigerante"){
			
			Audio(clipAudio);
			collisor.GetComponent<Acao>().Destroy();
			
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
			
			
		}
	}

	void Audio(AudioClip clip){

		audio.clip = clip;
		AudioSource.PlayClipAtPoint(clip, transform.position, 0.2f);
	}

	void LoadLevel() {

		Application.LoadLevel("Menu");
	}




	void OnGUI(){
		GUI.skin = textbox;


		Vector2 Pivot = new Vector2(posX + width / 2.0f, posY + height / 2.0f);
		GUIUtility.RotateAroundPivot(rotationAngle, Pivot);
		GUI.Button(new Rect(posX,posY,width,height2)," ");	
		GUI.Box(new Rect(posX,posY,width,height)," ");
		GUI.matrix = Matrix4x4.identity;
	
		if(QntVida > 200){
			
			GUI.skin.button.normal.background = fundomax;
			
		}
		if(QntVida > 70 && QntVida < 200){
			
			GUI.skin.button.normal.background = fundobom;
			
		}
		if(QntVida < 70){

			GUI.skin.button.normal.background = fundomin;
		}




	}




}


