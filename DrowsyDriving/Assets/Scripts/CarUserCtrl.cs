using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Vehicles.Car;

[RequireComponent(typeof (CarController))]

public class CarUserCtrl : MonoBehaviour {
	public bool delay;
	public float seconds;
	private CarController m_Car; // the car controller we want to use


	private void Awake()
	{
		// get the car controller
		m_Car = GetComponent<CarController>();
	}

	IEnumerator inputDelay(float h, float v, float handbrake, bool brake, float time) {
		yield return new WaitForSeconds(time);
		m_Car.Move (h, v, v, handbrake, brake);
	}

	private void Update()
	{
		if (delay) {
			// pass the input to the car!
			float h = CrossPlatformInputManager.GetAxis("Horizontal");
			float v = CrossPlatformInputManager.GetAxis("Vertical");

			#if !MOBILE_INPUT
			float handbrake = CrossPlatformInputManager.GetAxis("Jump");
			bool brake = CrossPlatformInputManager.GetButton("Fire2");
			StartCoroutine( inputDelay(h, v, handbrake, brake, seconds) );
			#else
			bool brake = CrossPlatformInputManager.GetButton("Fire2");
			StartCoroutine( inputDelay(h, v, v, brake, seconds) );
			#endif
		} else {
			// pass the input to the car!
			float h = CrossPlatformInputManager.GetAxis ("Horizontal");
			float v = CrossPlatformInputManager.GetAxis ("Vertical");

			#if !MOBILE_INPUT
			float handbrake = CrossPlatformInputManager.GetAxis ("Jump");
			bool brake = CrossPlatformInputManager.GetButton ("Fire2");
			m_Car.Move (h, v, v, handbrake, brake);
			#else
			m_Car.Move(h, v, v, 0f);
			#endif
		}
	}
}
