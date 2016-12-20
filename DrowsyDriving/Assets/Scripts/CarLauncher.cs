using UnityEngine;
using System.Collections;

public class CarLauncher : MonoBehaviour {
	public float power = 25;

	void Awake () {
		Vector3 speed = power * transform.forward;
		GetComponent<Rigidbody> ().velocity = speed;
	}
}
