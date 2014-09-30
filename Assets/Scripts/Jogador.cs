using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {

	float rotationAngle = 180;

	public bool timerligado;
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
	

	public AudioClip clipAlimento;
	public AudioClip clipAcao;

	TrailRenderer trail;


	// Use this for initialization
	void Start () {
		QntVida=50;
		MaxQntVida=100;
	
		renderer.enabled = true;

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
		if( QntVida < MaxQntVida && timerligado == true)
		{
			QntVida = QntVida - 0.02f;
		
		}

		if(QntVida<=10)
		{
			Handheld.Vibrate();
			collider2D.enabled = false;
			QntVida += 5;
			Invoke("LoadLevel", 1f);
		}
		if(QntVida > 90)
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

		if ( collisor.tag == "Acao"){

			if (QntVida>10)
			{
				QntVida = QntVida - 10f;

			}

				
			collisor.GetComponent<Acao>().Destroy();


			//Audio(clipAlimento);
		}
		else if(collisor.tag == "Alimentos"){

			//Audio(clipAcao);
			collisor.GetComponent<Acao>().Destroy();

			if (QntVida<MaxQntVida)
			{
				QntVida = QntVida + 10f;
				
			}

			/*if(!vidas.Remover()){

				collider2D.enabled = false;
				Invoke("LoadLevel", 1f);
				//pontos.Recorde ();


			}*/
		}
	}

	/*void Audio(AudioClip clip){

		audio.clip = clip;
		AudioSource.PlayClipAtPoint(clip, transform.position, 0.2f);
	}*/

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
	
		if(QntVida > 70){
			
			GUI.skin.button.normal.background = fundomax;
			
		}
		if(QntVida > 30 && QntVida < 70){
			
			GUI.skin.button.normal.background = fundobom;
			
		}
		if(QntVida < 30){

			GUI.skin.button.normal.background = fundomin;
		}




	}


}


