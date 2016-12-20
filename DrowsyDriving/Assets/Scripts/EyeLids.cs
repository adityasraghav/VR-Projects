using UnityEngine;
using System.Collections;

public class EyeLids : MonoBehaviour {
	public AnimatorClipInfo clip;
	public bool animate = false;
	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
		//gameObject.SetActive (false);
	}
	
//	void OnEnable() {
//		if(anim != null)
//			anim.SetTrigger ("Blink");
//
//		StartCoroutine ("wait", 0.5);
//	}
	float time = 0;
	int offset = 5;
	void Update () {
		time += Time.deltaTime;
		if (animate && time > offset) {
			offset = Random.Range (10, 15);
			//print (offset);
			time = 0;
			anim.SetTrigger ("Blink");
		}
	}

	IEnumerator wait(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		gameObject.SetActive (false);
	}
}
