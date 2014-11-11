using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public MotionBlur mBlur;

	private Vector3 position;

	public GameObject Score;
	public GameObject Tempo;

	public GUIStyle btnJogar;
	public GUIStyle btnReiniciar;
	private float posX;
	private float posY;
	private float height;
	private float width;
	private float heightButton;
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
	private bool guiAtivo;
	private bool startAtivo;


	public enum gameState{
		main,
		game,
		gameOver,

	}
	public static gameState state;
	public GameObject mainUI;
	public GameObject gameUI;
	public GameObject gameOverUI;


	//public GameObject personagem;
	//private Pontuacao _pontuacao;	



	void Awake() {


		QntVida = 100;
		MaxQntVida = 400;
		width = Screen.width/13;
		posX = Screen.width - (width + 15);
		posY = Screen.height/6;
		height = Screen.height/1.4f;

		/*personagem = Instantiate (personagem.transform, 
		                          personagem.transform.position, 
		                          personagem.transform.rotation) as GameObject;*/

		/*LifeBar = Instantiate (LifeBar.transform, 
		                      LifeBar.transform.position, 
		                      LifeBar.transform.rotation) as GameObject;*/

		/*_pontuacao = GameObject.FindGameObjectWithTag("Score").GetComponent<Pontuacao>() 
			as Pontuacao;*/

				}

	void Start () {
		mBlur = GameObject.Find("Main Camera").GetComponent<MotionBlur>();
		mBlur.enabled = false;
		guiAtivo = false;
		startAtivo = false;
		mainUI.SetActive(false);
		gameUI.SetActive(false);
		gameOverUI.SetActive (false);

		switch (state) {
		case gameState.main:
			mainUI.SetActive(true);
			break;
		case gameState.game:
			gameUI.SetActive(true);
			break;
		case gameState.gameOver:
			gameOverUI.SetActive (true);
			break;
		}

	}
	

	void Update () {

				switch (state) {
				case gameState.main:
				startAtivo = true;
			Time.timeScale = 0;
						break;
		
				case gameState.game:
			//criar barra de vida
			Time.timeScale = 1;
						guiAtivo = true;
						startAtivo = false;
						heightButton = Screen.height / 1.4f * (QntVida / MaxQntVida);

						if (QntVida < MaxQntVida) {
								QntVida -= 0.1f;
					
						}
			
						if (QntVida <= 20) {
								//Handheld.Vibrate();
								QntVida += 5;
								//StartCoroutine(GameEnd());
								Invoke ("LoadLevel", 1f);
						}
			
			
			
						if (QntVida > 350) {

								Invoke ("LoadLevel", 1f);
				
						}
						break;
		
				case gameState.gameOver:
				guiAtivo = false;
						break;
				}

		}




	public IEnumerator GameStart(){

		mainUI.SetActive (false);
		gameUI.SetActive (true);
		gameOverUI.SetActive (false);
		state = gameState.game;

		yield return null;

	}



	void LoadLevel(){

		Application.LoadLevel(1);
	}
	void OnGUI(){
		if (guiAtivo) {

						GUI.skin = layoutBarra;
						Vector2 Pivot = new Vector2 (posX + width / 2.0f, posY + height / 2.0f);
						GUIUtility.RotateAroundPivot (rotationAngle, Pivot);
						GUI.Button (new Rect (posX, posY, width, heightButton), " ");	
						GUI.Box (new Rect (posX, posY, width, height), " ");
						GUI.matrix = Matrix4x4.identity;
						GUI.Label (new Rect (posX - 20, Screen.height/2 + 300, 100f, 50f), QntVida.ToString ("F0"), indicador);
		
		
						if (QntVida > 320) {
			
								GUI.skin.button.normal.background = fundomax_G;
								Pontuacao.speed = 2F;
						}
				
						if (QntVida > 250) {
			
								GUI.skin.button.normal.background = fundomax_M;
								mBlur.enabled = true;
								Pontuacao.speed = 2F;

						}
						if (QntVida > 120 && QntVida < 250) {
			
								GUI.skin.button.normal.background = fundobom_M;
								mBlur.enabled = false;
								Pontuacao.speed = 3F;
						}
						if (QntVida > 70 && QntVida < 120) {
			
								GUI.skin.button.normal.background = fundobom_G;
								Pontuacao.speed = 4F;



			
						}
						if (QntVida < 70 && QntVida > 40) {
								
								Pontuacao.speed = 2F;
								GUI.skin.button.normal.background = fundomin_M;
								//Handheld.Vibrate();

						}
		
						if (QntVida < 40) {
								Pontuacao.speed = 2F;
								GUI.skin.button.normal.background = fundomin_G;
						}
				}

		if (startAtivo) {
				
			if(GUI.Button (new Rect (Screen.width / 2 - 200, Screen.height /3 + 150, 400F, 100F), "", btnJogar)){

				StartCoroutine(GameStart());
			}
		}


	}



}
