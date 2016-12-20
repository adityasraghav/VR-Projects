using UnityEngine;
using System.Collections;

public class UserTracking : MonoBehaviour {

	public Transform user;
	public float maxDistance;
	public bool keepDistance;
	UnityStandardAssets.Vehicles.Car.CarAIControl cac;
	UnityStandardAssets.Vehicles.Car.CarController cc;
	bool slowing = false;
	bool drivingDisabled = false;

	void Start() {
		cac = GetComponent<UnityStandardAssets.Vehicles.Car.CarAIControl> ();
		cc = GetComponent<UnityStandardAssets.Vehicles.Car.CarController> ();
	}

	void Update () {
		if (keepDistance) {
			float distance = Vector3.Distance (user.position, transform.position);
			//print (distance);
			if (distance < maxDistance) {
				//cac.m_Driving = true;
				StopCoroutine("delay");
				cc.m_Topspeed = 90f;
				slowing = false;
				if (drivingDisabled) {
					cac.m_Driving = true;
					drivingDisabled = false;
				}
			} else {
				//cac.m_Driving = false;
				if (!slowing) {
					StartCoroutine ("delay", 0.3);
					slowing = true;
				}
			}
		}
	}

	IEnumerator delay(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		cc.m_Topspeed = 80f;
		yield return new WaitForSeconds(waitTime);
		cc.m_Topspeed = 70f;
		yield return new WaitForSeconds(waitTime);
		cc.m_Topspeed = 60f;
		yield return new WaitForSeconds(waitTime);
		cc.m_Topspeed = 50f;
		yield return new WaitForSeconds(waitTime);
		cc.m_Topspeed = 40f;
		yield return new WaitForSeconds(waitTime);
		cc.m_Topspeed = 30f;
		yield return new WaitForSeconds(waitTime);
		cc.m_Topspeed = 20f;
		yield return new WaitForSeconds(waitTime);
		cc.m_Topspeed = 10f;
		yield return new WaitForSeconds(waitTime);
		cac.m_Driving = false;
		drivingDisabled = true;
	}
}
