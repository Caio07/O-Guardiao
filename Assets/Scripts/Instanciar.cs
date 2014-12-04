using UnityEngine;
using System.Collections;

public class Instanciar : MonoBehaviour {

	public float minSpawntime = 1;
	public float maxSpawntime = 10;
	public float spawnItem;

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

		if(Pontuacao.pontos > 40){

			maxSpawntime = 2;

		}
		else if(Pontuacao.pontos > 30){
			
			maxSpawntime = 4;
			
		}
		else if(Pontuacao.pontos > 20){
			
			maxSpawntime = 6;
			
		}
		else if(Pontuacao.pontos > 10){
			
			maxSpawntime = 8;
			
		}
	}


	bool RandomItem(){

		if (Itens.Length > 0){

			index = Random.Range(0, Itens.Length);
			return true;
		}
		return false;

	}

	private IEnumerator Instanciador(){

		spawnItem = Random.Range(minSpawntime, maxSpawntime);

		yield return new WaitForSeconds(spawnItem);
		if ( RandomItem()){

			item = Instantiate(Itens[index], new Vector2(transform.position.x, Random.Range(minX,maxX))
			                   ,Quaternion.Euler(0,0,Random.Range(-160,160)))as GameObject;
			Audio(clipAudio);

			if (item.transform.position.x > 0){

				item.rigidbody2D.AddForce(new Vector2(-leftForce,upForce));
				                          }
		    else{
					item.rigidbody2D.AddForce(new Vector2(leftForce,upForce ));
				}

StartCoroutine("Instanciador");
			}

		}

	void Audio(AudioClip clip){
		
		audio.clip = clip;
		AudioSource.PlayClipAtPoint(clip, transform.position, 0.2f);
	}

}


