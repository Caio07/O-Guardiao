using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Glicose : MonoBehaviour {


		public static Text text;

		// Use this for initialization
		void Start () {

				text = GetComponent<Text> ();
		}
		void Update(){

				text.text = GameManager.QntVida.ToString("F0");
		}
}
