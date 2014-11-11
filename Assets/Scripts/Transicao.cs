using UnityEngine;
using System.Collections;

public class Transicao : MonoBehaviour {

	// Use this for initialization
	public Texture2D textura;
	private float tempo = 0.0f;

	void Update(){}
	void OnGUi(){
		
		Color color = Color.white;
		color.a =Mathf.Lerp(1.0f, 0 , (Time.time - tempo));
		GUI.color = color;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), textura);
		
	}
	void OnLevelWasLoaded(){
		
		tempo = Time.time;
		
	}
}
