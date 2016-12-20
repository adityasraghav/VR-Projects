using UnityEngine;
using System.Collections;

public class speech : MonoBehaviour {
	public AudioClip intro;
	public AudioClip part2;
	private AudioSource emma;
	private bool isPlaying;
	private int speechNum;
	private bool stop = false;

	void Start() {
		emma = GetComponent<AudioSource> ();
		isPlaying = true;  // is a regular comment currently playing
		speechNum = 1;  // variable which allows regular comments to take turns
		StartCoroutine ("delay", 6.5);
	}

	void Update() {
		// make sure a clip is not already playing
		if (!isPlaying && !stop) {
			// each regular comment made by a person is a case
			// this allows adding comments and changing delays an easy task
			switch (speechNum) {
			case 1:
				isPlaying = true;
				emma.clip = intro;
				emma.Play ();
				StartCoroutine ("delay", intro.length + 1);
				++speechNum;
				break;
			case 2:
				isPlaying = true;
				emma.clip = part2;
				emma.Play ();
				StartCoroutine ("delay", part2.length + 2);
				//speechNum = 1;
				stop = true;
				break;
			default:
				Debug.Log ("OOPS");
				break;
			}
		}
	}

	// wait for the duration of the clip and set the flag to false
	IEnumerator delay(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		isPlaying = false;
	}
}
