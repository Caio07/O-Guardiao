using UnityEngine;
using System.Collections;

public class Personagem : MonoBehaviour {


	
	//private GrayscaleEffect _gray;
	// Use this for initialization
	void Start () {

		//_gray = GameObject.Find("Main Camera").GetComponent<GrayscaleEffect>();
		//_gray.enabled = false;

		

	}
	
	// Update is called once per frame
	void Update () {
				/*if (Input.GetMouseButtonDown(0) && CircleBar.clicado == true)
						StartCoroutine(Effect());	*/
	
	}

	/*private void OnMouseDown(){
		
		if( CircleBar.clicado == true){
			StartCoroutine(Effect());	
		}
	}*/

	/*IEnumerator Effect(){
		
		_gray.enabled = true;
		GameManager.QntVida += 95f;
		yield return new WaitForSeconds(3);
		_gray.enabled = false;
		CircleBar.clicado = false;

			
	}*/

}
