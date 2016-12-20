using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class SteeringWheel : MonoBehaviour {

	public int degreeOfFreedom = 240;
	public CarUserCtrl carUserCtrl;

	private Transform wheel;

	void Start () {
		wheel = GetComponent<Transform> ();
	}

	IEnumerator inputDelay(float h, float time) {
		yield return new WaitForSeconds(time);
		float angle = -h * degreeOfFreedom;
		wheel.localRotation = Quaternion.Euler (angle, 0.0f, 7.0191f);
	}

	void FixedUpdate () {
		if (carUserCtrl.delay) {
			float h = CrossPlatformInputManager.GetAxis ("Horizontal");
			StartCoroutine( inputDelay (h, carUserCtrl.seconds) );
		} else {
			float h = CrossPlatformInputManager.GetAxis ("Horizontal");
			float angle = -h * degreeOfFreedom;
			wheel.localRotation = Quaternion.Euler (angle, 0.0f, 7.0191f);
		}
	}
}
