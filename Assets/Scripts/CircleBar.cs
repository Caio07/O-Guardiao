using UnityEngine;
using System.Collections;

public class CircleBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(MyCoroutine());
	}
	
	// Update is called once per frame
	void Update () {

		float revealOffset = (float)(Time.timeSinceLevelLoad) ; 
		gameObject.renderer.material.SetFloat ("_Cutoff", revealOffset);






			
			
	}

	IEnumerator MyCoroutine(){



        yield return new WaitForSeconds(5);
		iTween.ScaleTo(gameObject, iTween.Hash("looptype", "pingpong","x",2.4,"time",1, "y",2.4,"z",2.4));

	}

}
