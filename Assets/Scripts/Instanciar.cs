using UnityEngine;
using System.Collections;

public class Instanciar : MonoBehaviour {

	public float minSpawntime = 1;
	public float maxSpawntime = 5;
	public float spawnItem;
	public int spawnCount;
	public float startWait;
		public float waveWait;


	public GameObject [] Itens;
	private GameObject item;
	private int index;
	public AudioClip clipAudio;


	public float upForce = 400f;
	public float leftForce = 100f;
	public static float minX, maxX;//posicao do instanciador

	// Use this for initialization
	void Start () {
	
		minX = GerenciarCamera.Minx();
		maxX = GerenciarCamera.Maxx();
		StartCoroutine("Instanciador");
	}

	void Update(){

		if(Pontuacao.pontos > 80){

			maxSpawntime = 0.3f;

		}
		else if(Pontuacao.pontos > 60){
			
			maxSpawntime = 0.5f;
			
		}
		else if(Pontuacao.pontos > 40){
			
			maxSpawntime = 0.7f;
			
		}
		else if(Pontuacao.pontos > 20){
			
			maxSpawntime = 0.9f;
			
		}
	}


	

	private IEnumerator Instanciador(){

				yield return new WaitForSeconds (startWait);

				while (true) {

				for (int i = 0; i < spawnCount; i++) {
		
						
								spawnItem = Random.Range (minSpawntime, maxSpawntime);

								if (RandomItem ()) {

										item = Instantiate (Itens [index], new Vector2 (transform.position.x, Random.Range (minX, maxX))
			                   , Quaternion.Euler (0, 0, Random.Range (-160, 160)))as GameObject;
										Audio (clipAudio);

										if (item.transform.position.x > 0) {

												item.rigidbody2D.AddForce (new Vector2 (-leftForce, upForce));
										} else {
												item.rigidbody2D.AddForce (new Vector2 (leftForce, upForce));
										}
										yield return new WaitForSeconds (spawnItem);
								}


							
						}
						yield return new WaitForSeconds (waveWait);
				}

		}

	void Audio(AudioClip clip){
		
		audio.clip = clip;
		AudioSource.PlayClipAtPoint(clip, transform.position, 0.2f);
	}

		bool RandomItem(){

				if (Itens.Length > 0){

						index = Random.Range(0, Itens.Length);
						return true;
				}
				return false;

		}
}


