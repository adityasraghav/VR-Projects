using UnityEngine;
using System.Collections;

public class TrafficBrake : MonoBehaviour {

	public bool brake;
	public UserTracking ut;
	UnityStandardAssets.Vehicles.Car.CarAIControl cac;
	//bool outOfSpace = false;

	void Start() {
		cac = gameObject.transform.parent.gameObject.GetComponent<UnityStandardAssets.Vehicles.Car.CarAIControl> ();
	}

//	void Update() {
//		// prevent runaway car
//		if (!outOfSpace && transform.position.x < -1462f) {
//			brake = false;
//			cac.m_Driving = false;
//			ut.keepDistance = false;
//			//print ("BRAKE!");
//			outOfSpace = true;
//		}
//	}

	void OnTriggerEnter(Collider other) {
		if (brake && other.tag == "Player") {
			cac.m_Driving = false;
			ut.keepDistance = false;
			//print ("BRAKE!");
		}
	}
}
