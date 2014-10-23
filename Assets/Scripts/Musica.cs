using UnityEngine;
using System.Collections;

public class Musica : MonoBehaviour {

	public AudioClip clipAudio;

	void Start () {
	
	}
	

	void Update () {
		Audio(clipAudio);
	}

	void Audio(AudioClip clip){
		
		audio.clip = clip;
		AudioSource.PlayClipAtPoint(clip, transform.position, 0.2f);
	}
}
