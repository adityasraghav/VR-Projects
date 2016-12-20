using UnityEngine;
using System.Collections;

public class ConstructionTrigger : MonoBehaviour {

	public UnityStandardAssets.Vehicles.Car.CarController collisionCar;
	public TrafficBrake tb;
	public UserTracking ut;
	public GameObject lights;

	public GameObject car;
	public Transform spawnPoint;
	public bool sleepy = false;
	public Animator fade;

	void Start () {
		StartCoroutine (delayLights (10));
	}

	void OnTriggerEnter (Collider other) {
		if (sleepy) {
			if (other.CompareTag ("FrontCarCollision")) {
				StartCoroutine ("delay", 0.5f);
				tb.brake = true;
				lights.SetActive (true);
				StartCoroutine(spawn (6f));
				StartCoroutine(despawn (8f));
				StartCoroutine(endScene (11f));
			}
		} else {
			if (other.CompareTag ("Player")) {
				ut.maxDistance = 0f;
				lights.SetActive (true);
				StartCoroutine(spawn (1f));
				StartCoroutine(despawn (3f));
				StartCoroutine(endScene (6f));
			}
		}
	}

	IEnumerator delay(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		ut.maxDistance = 43f;
		yield return new WaitForSeconds(waitTime);
		ut.maxDistance = 36f;
		yield return new WaitForSeconds(waitTime);
		ut.maxDistance = 30f;
	}

	IEnumerator delayLights(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		lights.SetActive (false);
	}

	IEnumerator spawn(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		Instantiate(car, spawnPoint.position, spawnPoint.rotation);
		ut.maxDistance = 50f;
	}

	IEnumerator despawn(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		GameObject carSpawned = GameObject.FindGameObjectWithTag ("RearCarCollision");
		DestroyImmediate (carSpawned);
	}

	IEnumerator endScene(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		fade.SetTrigger ("Fade");
		yield return new WaitForSeconds(0.5f);
		Application.LoadLevel (4);
	}
}
