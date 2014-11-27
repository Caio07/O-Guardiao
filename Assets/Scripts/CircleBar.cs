using UnityEngine;
using System.Collections;

public class CircleBar : MonoBehaviour {

	public int timetoComplete = 3;
	public static bool clicado;
	public static int contadorinicio = 0;

	// Use this for initialization
	void Start () {


		clicado = false;
		StartCoroutine(Progresso(timetoComplete));
	}
	
	// Update is called once per frame
	void Update () {
		if(CircleBar.clicado == false){
			iTween.Stop ();
		}

			
	}




	IEnumerator Progresso(float time)
	{
		float rate = -1 / time;
		float i = contadorinicio;
		while (i > -1)
		{
			i += Time.deltaTime * rate;
			gameObject.renderer.material.SetFloat("_Cutoff", i);
			yield return 0;
		}
		if(i<-1.005){

			StartCoroutine(MyCoroutine());
			clicado = true;


		}


	}

	IEnumerator MyCoroutine(){



        yield return new WaitForSeconds(1);
		iTween.ScaleTo(gameObject, iTween.Hash("looptype", "pingpong","x",2.4,"time",1, "y",2.4,"z",2.4));


	}



}
