using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

	float rotationAngle = 180;
	public GameObject personagem;



	public bool timerligado = false;
	private Vector3 position;
	public GUISkin textbox;
	public float posX;
	public float posY;
	public float height;
	public float width;
	public float height2;
	public float QntVida;
	public float MaxQntVida;


	public Texture2D fundomax;
	public Texture2D fundomin;
	public Texture2D fundobom;
	

	public AudioClip clipAudio;


	TrailRenderer trail;


	// Use this for initialization
	void Start () {

	


		QntVida=100;
		MaxQntVida=300;
		renderer.enabled = true;

		GameObject clone;
		clone = Instantiate(personagem.transform, 
		                    personagem.transform.position, 
		                    personagem.transform.rotation) as GameObject;

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
				
			}


			}

		else if(collisor.tag == "Sorvete"){
			
			Audio(clipAudio);
			collisor.GetComponent<Acao>().Destroy();
			
			if (QntVida<MaxQntVida)
			{
				QntVida = QntVida + 57f;
				
			}
			
			
		}

		else if(collisor.tag == "Cenoura"){
			
			Audio(clipAudio);
			collisor.GetComponent<Acao>().Destroy();
			
			if (QntVida<MaxQntVida)
			{
				QntVida = QntVida + 35f;
				
			}
			
			
		}

		else if(collisor.tag == "Pao"){
			
			Audio(clipAudio);
			collisor.GetComponent<Acao>().Destroy();
			
			if (QntVida<MaxQntVida)
			{
				QntVida = QntVida + 95f;
				
			}
			
			
		}

		else if(collisor.tag == "Refrigerante"){
			
			Audio(clipAudio);
			collisor.GetComponent<Acao>().Destroy();
			
			if (QntVida<MaxQntVida)
			{
				QntVida = QntVida + 63f;
				
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


