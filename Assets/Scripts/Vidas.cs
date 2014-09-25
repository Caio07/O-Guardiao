using UnityEngine;
using System.Collections;

public class Vidas : MonoBehaviour {

	public Texture2D[] Vida;
	private int TamanhoVidas;
	private int index = 0;


	// Use this for initialization
	void Start () {
	
		/*guiTexture.texture = Vida[0];
		TamanhoVidas = Vida.Length;*/

	}
	

	/*
	public bool Remover(){

		if ((TamanhoVidas<0)){

			return false;
		}
		if (index < (TamanhoVidas) -1){

			index +=1;
			guiTexture.texture = Vida[index];
			return true;
			}
		else {
			return false;
		}
	}*/
}
