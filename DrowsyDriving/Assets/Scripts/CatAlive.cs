using UnityEngine;
using System.Collections;

public class CatAlive : MonoBehaviour {
	public AudioSource sound;
	public AudioClip almost;
	public AudioClip goodjob;
	public catMovement cm;
	public bool sleepy;
	public Animator anim;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			if (cm.notDead) {
				if (sleepy)
					sound.clip = almost;
				else
					sound.clip = goodjob;
				sound.pitch = 1.05f;
				sound.Play ();
			}
			StartCoroutine (delay(5f));
		}
	}

	IEnumerator delay(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		anim.SetTrigger ("Full");
		yield return new WaitForSeconds(1.5f);
		Application.LoadLevel (2);
	}
}
