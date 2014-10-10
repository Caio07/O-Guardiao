using UnityEngine;
using System.Collections;

public class menu_pause : MonoBehaviour {

	public Texture2D[] textura;

	// Use this for initialization
	void Start () {

		guiTexture.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){

			Application.LoadLevel(5);

	}

	void OnMouseExit(){
		
		gameObject.guiTexture.texture = textura[0];
	}

	void OnMouseEnter(){

		gameObject.guiTexture.texture = textura[1];
	}
}
