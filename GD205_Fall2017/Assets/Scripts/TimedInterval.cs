using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedInterval : MonoBehaviour {

	//initial goTime means that's when it will start happening
	public float goTime = 30;
	//interval is how frequently it will run after that
	public float interval = 3;

	// Update is called once per frame
	void Update () {
		//checking if Time.time (time elapsed since the scene began in seconds) has surpassed our timer/alarm (goTime)
		if (Time.time >= goTime){
			//we add the interval amount to our goTime to reset the clock, otherwise it will run every frame
			goTime += interval;

			
			//do the thing you want to happen at these intervals
			//ScreenShake is the other script, and Shake() is a function of it
			//the arguments are duration and magnitude of the shake
			//StartCoroutine(ScreenShake.Shake(0.25f, 0.5f));
			Debug.Log("do");
		}

	}
}