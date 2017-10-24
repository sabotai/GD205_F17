using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedAction : MonoBehaviour {

	public float startTime = 5f;
	public float interval = 3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= startTime) {
			startTime += interval;
			Debug.Log ("doing something");

			StartCoroutine (ScreenShake.Shake (0.25f, 0.5f));
		}
		
	}
}
