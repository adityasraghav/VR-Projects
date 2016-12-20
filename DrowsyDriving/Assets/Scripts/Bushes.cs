using UnityEngine;
using System.Collections;

public class Bushes : MonoBehaviour {
	MeshRenderer mr;

	void Start() {
		mr = GetComponent<MeshRenderer> ();
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			mr.enabled = false;
		}
	}
	void OnTriggerExit(Collider other) {
		if (other.tag == "Player") {
			mr.enabled = true;
		}
	}
}
