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
	private bool gameOverAtivo;

	public enum gameState{
		main,
		game,
		gameOver,

	}
	public gameState state;
	public GameObject mainUI;
	public GameObject gameUI;
	public GameObject gameOverUI;
	public GameObject finalScoretext;

	//public GameObject personagem;
	//private Pontuacao _pontuacao;	



	void Awake() {


		QntVida = 100;
		MaxQntVida = 400;
		width = Screen.width/13;
		posX = Screen.width - (width + 15);
		posY = Screen.height/4;
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
		//mBlur = GameObject.Find("Main Camera").GetComponent<MotionBlur>();
		//mBlur.enabled = false;
		guiAtivo = false;
		startAtivo = false;
		gameOverAtivo = false;
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
						break;
		
				case gameState.game:
			//criar barra de vida
			
						guiAtivo = true;
						startAtivo = false;
						heightButton = Screen.height / 1.4f * (QntVida / MaxQntVida);

						if (QntVida < MaxQntVida) {
								QntVida -= 0.1f;
					
						}
			
						if (QntVida <= 20) {
								//Handheld.Vibrate();
								QntVida += 5;
								StartCoroutine(GameEnd());
								//Invoke ("LoadLevel", 1f);
						}
			
			
			
						if (QntVida > 350) {

								Invoke ("LoadLevel", 1f);
				
						}
						break;
		
				case gameState.gameOver:
				guiAtivo = false;
				gameOverAtivo = true;
						break;
				}

		}
	/*void Multiplicador(string mult){
		
		
		GameObject texto = new GameObject("Multiplicar");
		Instantiate(texto);
		GUIText myText = texto.AddComponent<GUIText>();
		myText.transform.position = new Vector3(0.09f,0.8f,0f);
		
		myText.guiText.text = mult;
		myText.guiText.fontSize = 14;
		iTween.FadeTo( texto, iTween.Hash( "alpha" , 0.0f , "time" , .5 , "easeType", "easeInSine") );
		Destroy(texto,1);
	}*/

	IEnumerator GameEnd(){
		mainUI.SetActive (false);
		gameUI.SetActive (false);
		gameOverUI.SetActive (true);
		state = gameState.gameOver;

		finalScoretext.guiText.text = "Pontuaçao Final";


		StopAllCoroutines ();
		QntVida = 100;

		yield return null;
	}

	IEnumerator GameStart(){

		mainUI.SetActive (false);
		gameUI.SetActive (true);
		gameOverUI.SetActive (false);
		state = gameState.game;

		yield return null;

	}

	void OnGUI(){
		if (guiAtivo) {

						GUI.skin = layoutBarra;
						Vector2 Pivot = new Vector2 (posX + width / 2.0f, posY + height / 2.0f);
						GUIUtility.RotateAroundPivot (rotationAngle, Pivot);
						GUI.Button (new Rect (posX, posY, width, heightButton), " ");	
						GUI.Box (new Rect (posX, posY, width, height), " ");
						GUI.matrix = Matrix4x4.identity;
						GUI.Label (new Rect (posX - 50, posY, 100f, 50f), QntVida.ToString ("F0"), indicador);
		
		
						if (QntVida > 320) {
			
								GUI.skin.button.normal.background = fundomax_G;
		
						}
				
						if (QntVida > 250) {
			
								GUI.skin.button.normal.background = fundomax_M;
								//mBlur.enabled = true;

						}
						if (QntVida > 120 && QntVida < 250) {
			
								GUI.skin.button.normal.background = fundobom_M;
								//Multiplicador("x2");
								//mBlur.enabled = false;
						}
						if (QntVida > 70 && QntVida < 120) {
			
								GUI.skin.button.normal.background = fundobom_G;
								//Multiplicador("x4");



			
						}
						if (QntVida < 70 && QntVida > 40) {
			
								GUI.skin.button.normal.background = fundomin_M;
								//Handheld.Vibrate();

						}
		
						if (QntVida < 40) {
			
								GUI.skin.button.normal.background = fundomin_G;
						}
				}

		if (startAtivo) {
				
			if(GUI.Button (new Rect (Screen.width / 3, Screen.height / 2, 200F, 50F), "", btnJogar)){

				StartCoroutine(GameStart());
			}
		}

		if (gameOverAtivo) {
			
			if(GUI.Button (new Rect (Screen.width / 3, Screen.height / 2, 200F, 50F), "", btnReiniciar)){
				
				StartCoroutine(GameStart());
				gameOverAtivo = false;

			}
		}
	}



}
