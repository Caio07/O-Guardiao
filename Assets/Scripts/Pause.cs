using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public bool CanPause;
	public GUISkin imagem;





	// Use this for initialization
	void Start () {
		CanPause = true;

	}
	
	// Update is called once per frame
	void Update () {
	



	}


	void OnGUI()
	{
		GUI.skin = imagem;
		if (GUI.Button(new Rect (20,30,40,40), ""))
		{
			if (CanPause)
			{
				Time.timeScale = 0;
				CanPause = false;
				renderer.enabled = true;

			
							

			}
			else
			{
				Time.timeScale=1;
				CanPause = true;
				renderer.enabled = false;
			
			}
		}
	
	}
}
