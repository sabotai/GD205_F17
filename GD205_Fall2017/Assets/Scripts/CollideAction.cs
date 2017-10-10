using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideAction : MonoBehaviour {

	AudioSource myAudio;
	public AudioClip boomSound;
	public AudioClip sphereCollide;

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collisionReport){
		Debug.Log ("ya done collid'd");
		myAudio.PlayOneShot(boomSound, 0.7F);

		if (collisionReport.gameObject.tag == "spherez") {
			myAudio.PlayOneShot(sphereCollide, 0.7F);
		}
	}
}
