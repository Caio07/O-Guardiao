using UnityEngine;
using System.Collections;

public class Instanciar : MonoBehaviour {

	public float minSpawntime = 1;
	public float maxSpawntime = 5;
	public float spawnItem;

	public GameObject [] Itens;
	private GameObject item;
	private int index;


	public float upForce = 400f;
	public float leftForce = 100f;
	public static float minX, maxX;//posicao do instanciador

	// Use this for initialization
	void Start () {
	
		minX = GerenciarCamera.Minx();
		maxX = GerenciarCamera.Maxx();
		StartCoroutine("Instanciador");
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

			item = Instantiate(Itens[index], new Vector2(Random.Range(minX,maxX), transform.position.y)
			                   ,Quaternion.Euler(0,0,Random.Range(-160,160)))as GameObject;
			minSpawntime ++;
			maxSpawntime++;

			if (item.transform.position.x > 0){

				item.rigidbody2D.AddForce(new Vector2(-leftForce,upForce));
				                          }
		    else{
					item.rigidbody2D.AddForce(new Vector2(leftForce,upForce ));
				}

StartCoroutine("Instanciador");
			}

		}

}


