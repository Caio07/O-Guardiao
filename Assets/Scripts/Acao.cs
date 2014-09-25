using UnityEngine;
using System.Collections;

public class Acao : MonoBehaviour {

	public bool isDead;
	private Vector3 screen;

	public float minY;
	public float maxY;

	public float rotDir = 50;

	// Use this for initialization
	void Start () {
	
		minY = GerenciarCamera.Miny();
		maxY = GerenciarCamera.Maxy();

	}
	
	// Update is called once per frame
	void Update () {
	
		Remover();

	}

public void Remover(){
	
	screen = Camera.main.WorldToScreenPoint(transform.position);
	if (isDead && screen.y < minY){
		
		Destroy(gameObject);
		
	}
	else{
		isDead = true;
		
	}

	transform.Rotate( new Vector3(0,0, rotDir) * Time.deltaTime);
	
}

public void Destroy()
	 {
		Destroy (gameObject);


	}

}