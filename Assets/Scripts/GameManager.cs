using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	private Vector3 position;

	public float posX;
	public float posY;
	public float height;
	public float width;
	public float heightButton;
	public float posNumero;
	public float QntVida;
	public float MaxQntVida;
	public GUISkin layoutBarra;
	public Texture2D fundomax;
	public Texture2D fundomin;
	public Texture2D fundobom;
	private float rotationAngle = 180;
	public GUIStyle indicador;
	public GameObject personagem;



	void Awake() {
		
		QntVida = 100;
		MaxQntVida = 300;
		width = Screen.width/13;
		posX = Screen.width - width;
		posY = Screen.height/4;
		height = Screen.height/1.4f;

		personagem = Instantiate (personagem.transform, 
		                          personagem.transform.position, 
		                          personagem.transform.rotation) as GameObject;

		/*LifeBar = Instantiate (LifeBar.transform, 
		                      LifeBar.transform.position, 
		                      LifeBar.transform.rotation) as GameObject;*/


				}

	void Start () {
	

	}
	

	void Update () {

		//Plataforma ();
		//criar barra de vida
		
		posNumero =  Screen.height/1.4f * (QntVida/MaxQntVida);
		heightButton = Screen.height/1.4f * (QntVida/MaxQntVida);

		/*if( QntVida < MaxQntVida)
		{
				QntVida -= 0.1f;
				
		}*/
		
		if(QntVida<=30)
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

	// Metodo para pegar touch ou clique do mouse
	/*private void Plataforma()
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
		
	}*/

	void OnGUI(){
		GUI.skin = layoutBarra;
		
		Vector2 Pivot = new Vector2(posX + width / 2.0f, posY + height / 2.0f);
		GUIUtility.RotateAroundPivot(rotationAngle, Pivot);
		GUI.Button(new Rect(posX,posY,width,heightButton)," ");	
		GUI.Box(new Rect(posX,posY,width,height)," ");
		GUI.matrix = Matrix4x4.identity;
		GUI.Label(new Rect(posX -10,posNumero, 100f, 50f),QntVida.ToString("F0"),indicador );
		
		
				
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
