using UnityEngine;
using System.Collections;

public class Relogio : MonoBehaviour {


	public float startTime;
	public float timeRemaining;

	

	// Use this for initialization
	void Start () {
		startTime = 60f;

	}
	
	// Update is called once per frame
	void Update () {

			CountDown();
			
		
	}
	
	public void CountDown(){


		timeRemaining = startTime - Time.timeSinceLevelLoad;
		ShowTime();
		if(timeRemaining <0)
		{
			Application.LoadLevel("Game Over");			
	    }
	
	
	}
	void ShowTime()
	{
		int minutes;
		int seconds;
		string timeString;
		
		minutes = (int)timeRemaining/60;
		seconds = (int)timeRemaining % 60;
		timeString = minutes.ToString() + ":" + seconds.ToString("D2");
		guiText.text = timeString;

	}

	

}