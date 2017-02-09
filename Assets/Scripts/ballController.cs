using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Goal") {
//			rb.useGravity = false;
			rb.AddForce (Vector3.up * 1000f);
			Destroy (gameObject, .5f);
		}
	}
}
