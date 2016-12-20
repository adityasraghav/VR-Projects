using UnityEngine;
using System.Collections;

public class Scene5Animator : MonoBehaviour {
	public bool sleepy;
	public AudioClip sorry;
	public AudioClip angry;
	public AudioClip police;
	public AudioSource sleepyGuy;
	public AudioSource cop;
	public Animator copAnim;
	public Transform copTrans;

	private bool isPlaying;
	private int speechNum;
	private bool stop = false;
	private bool lerpFlag = false;

	void Start() {
		isPlaying = true;  // is a regular comment currently playing
		speechNum = 1;  // variable which allows regular comments to take turns
		StartCoroutine ("delay", 2f);
	}

	void Update() {
		// make sure a clip is not already playing
		if (!isPlaying && !stop) {
			// each regular comment made by a person is a case
			// this allows adding comments and changing delays an easy task
			switch (speechNum) {
			case 1:
				isPlaying = true;
				if (sleepy) {
					sleepyGuy.clip = angry;
					sleepyGuy.Play ();
					StartCoroutine ("delayCop", angry.length + 2);
				} else {
					sleepyGuy.clip = sorry;
					sleepyGuy.Play ();
					StartCoroutine ("delayCop", sorry.length + 2);
				}
				++speechNum;
				break;
			case 2:
				isPlaying = true;
				cop.clip = police;
				cop.Play ();
				StartCoroutine ("delay", police.length + 2);
				//speechNum = 1;
				stop = true;
				break;
			default:
				Debug.Log ("OOPS");
				break;
			}
		}
		if (lerpFlag) {
			copTrans.position += copTrans.forward * Time.deltaTime * 2.7f;
			copTrans.localEulerAngles += new Vector3(0f, 1f, 0f) * Time.deltaTime * 33f;
		}
	}

	// wait for the duration of the clip and set the flag to false
	IEnumerator delay(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		isPlaying = false;
	}
	IEnumerator delayCop(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		copAnim.SetTrigger ("Walk");
		lerpFlag = true;
		yield return new WaitForSeconds(3f);
		isPlaying = false;
		lerpFlag = false;
	}
}
