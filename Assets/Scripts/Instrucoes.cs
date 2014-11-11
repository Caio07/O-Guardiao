using UnityEngine;
using System.Collections;

public class Instrucoes : MonoBehaviour {

	public GameObject instrucoes;
	// Use this for initialization
	void Start () {
	
		instrucoes.guiText.text="Acerte os alimentos na tela\n" + "e mantenha a glicose equilibrada o maior tempo possivel!";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
