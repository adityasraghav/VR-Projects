using UnityEngine;
using System.Collections;

public class Speedometer : MonoBehaviour {

	public GameObject car;
	public float updateRate = 1.0f;

	TextMesh dial;
	float timer;
	UnityStandardAssets.Vehicles.Car.CarController cc;

	// Use this for initialization
	void Start () {
		dial = GetComponent<TextMesh> ();
		timer = 0f;
		cc = car.GetComponent<UnityStandardAssets.Vehicles.Car.CarController> ();
	}
	
	// Update is called once per frame
	void Update () {
		// only update speedometer if enough time has elapsed
		timer += Time.deltaTime;
		if (timer >= updateRate) {
			int currSpeed = (int)cc.CurrentSpeed;
			dial.text = currSpeed.ToString();
			timer = 0f;
		}
	}
}
