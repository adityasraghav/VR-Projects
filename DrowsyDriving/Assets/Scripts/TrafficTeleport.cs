using UnityEngine;
using System.Collections;

public class TrafficTeleport : MonoBehaviour {
	//public float rotY; // 183.74f
	public Transform TP_Target;
	public bool launch = true;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Traffic") {
			Transform car = other.gameObject.transform.parent.parent;
			Rigidbody rb = car.GetComponent<Rigidbody> ();
			car.transform.position = new Vector3 (TP_Target.position.x, TP_Target.position.y, TP_Target.position.z);
			car.transform.localEulerAngles = new Vector3 (0f, TP_Target.localEulerAngles.y, 0f);
			if(launch)
				rb.velocity = new Vector3(-15f, 0f, -15f);
			else
				rb.velocity = new Vector3(0f, 0f, 0f);
			rb.angularVelocity = new Vector3(0f, 0f, 0f);
		}
	}
}
