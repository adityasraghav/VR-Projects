using UnityEngine;
using System.Collections;

public class PreventTrafficCollisions : MonoBehaviour {
	public UnityStandardAssets.Vehicles.Car.CarAIControl cac;
	public UnityStandardAssets.Vehicles.Car.CarController cc;

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Traffic") || other.CompareTag ("Player")) {
			cac.m_Driving = false;
			StartCoroutine (delay (1));
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Traffic") || other.CompareTag ("Player")) {
			cac.m_Driving = true;
			cc.m_Topspeed = 75f;
		}
	}

	IEnumerator delay(float waitTime) {
		yield return new WaitForSeconds (waitTime);
		cac.m_Driving = true;
	}
}
