using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	public GameObject prefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Ray beam = Camera.main.ScreenPointToRay (Input.mousePosition);

		Debug.DrawRay (beam.origin, beam.direction * 1000f);

		RaycastHit beamHit = new RaycastHit ();

		if (Physics.Raycast (beam, out beamHit, 1000f)) {
			Debug.Log ("you hit something at" + beamHit.point);
			if (Input.GetMouseButtonDown (0)) {
				beamHit.rigidbody.AddForce(Random.insideUnitSphere * 5000f);
			}
			if(Input.GetMouseButtonDown(1)){
				Instantiate (prefab, beamHit.point, Quaternion.identity);
			}
			if (Input.GetMouseButtonDown (2)) {
				Destroy(beamHit.collider.gameObject);
			}

		}
	}
}
