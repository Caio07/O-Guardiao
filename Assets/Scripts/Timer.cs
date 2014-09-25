using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public float startTime;
	public float timeRemaining;
	//public GUIText timer;



	// Use this for initialization
	void Start () {
	
		startTime = 0.0f;


	}
	
	// Update is called once per frame
	void Update () {
	
		CountDown();

	}

	void CountDown(){

		timeRemaining = startTime + Time.time;
		ShowTime();
		if(timeRemaining <0){
			timeRemaining =0;


		}

	}
	void ShowTime(){
		int minutes;
		int seconds;
		string timeString;

		minutes = (int)timeRemaining/60;
		seconds = (int)timeRemaining % 60;
		timeString = minutes.ToString() + ":" + seconds.ToString("D2");
		guiText.text = timeString;

	}




}
