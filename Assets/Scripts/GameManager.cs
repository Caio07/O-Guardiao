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
	public static float QntVida;
	public static float MaxQntVida;
	public GUISkin layoutBarra;
	public Texture2D fundomax_G;
	public Texture2D fundomin_G;
	public Texture2D fundobom_G;
	public Texture2D fundomax_M;
	public Texture2D fundomin_M;
	public Texture2D fundobom_M;
	private float rotationAngle = 180;
	public GUIStyle indicador;
	public GameObject personagem;
	//private Pontuacao _pontuacao;	



	void Awake() {


		QntVida = 100;
		MaxQntVida = 400;
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

		/*_pontuacao = GameObject.FindGameObjectWithTag("Score").GetComponent<Pontuacao>() 
			as Pontuacao;*/

				}

	void Start () {


	}
	

	void Update () {

	
			
		//criar barra de vida
		
		posNumero =  Screen.height/1.4f * (QntVida/MaxQntVida);
		heightButton = Screen.height/1.4f * (QntVida/MaxQntVida);

		if( QntVida < MaxQntVida)
		{
				QntVida -= 0.1f;
				
		}
		
		if(QntVida<=20)
		{
			Handheld.Vibrate();
			QntVida += 5;
			Invoke("LoadLevel", 1f);
		}
		
		
		
		if(QntVida > 350)
		{

			Invoke("LoadLevel", 1f);
			
		}

		
	}

	void Multiplicador(string mult){
		
		
		GameObject texto = new GameObject("Multiplicar");
		Instantiate(texto);
		GUIText myText = texto.AddComponent<GUIText>();
		myText.transform.position = new Vector3(0.09f,0.8f,0f);
		
		myText.guiText.text = mult;
		myText.guiText.fontSize = 14;
		iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );
		Destroy(texto,1);
	}


	void OnGUI(){
		GUI.skin = layoutBarra;
		Vector2 Pivot = new Vector2(posX + width / 2.0f, posY + height / 2.0f);
		GUIUtility.RotateAroundPivot(rotationAngle, Pivot);
		GUI.Button(new Rect(posX,posY,width,heightButton)," ");	
		GUI.Box(new Rect(posX,posY,width,height)," ");
		GUI.matrix = Matrix4x4.identity;
		GUI.Label(new Rect(posX -10,posNumero, 100f, 50f),QntVida.ToString("F0"),indicador );
		
		
		if(QntVida > 320){
			
			GUI.skin.button.normal.background = fundomax_G;
			
		}
				
		if( QntVida > 250){
			
			GUI.skin.button.normal.background = fundomax_M;
			
		}
		if(QntVida > 120 && QntVida < 250){
			
			GUI.skin.button.normal.background = fundobom_M;
			
		}
		if(QntVida > 70 && QntVida < 120){
			
			GUI.skin.button.normal.background = fundobom_G;
			Multiplicador("x2");



			
		}
		if(QntVida < 70 && QntVida > 40 ){
			
			GUI.skin.button.normal.background = fundomin_M;
		}
		
		if(QntVida < 40 ){
			
			GUI.skin.button.normal.background = fundomin_G;
		}
		
		
	}



}
