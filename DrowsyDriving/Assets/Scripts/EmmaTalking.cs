using UnityEngine;
using System.Collections;

public class EmmaTalking : MonoBehaviour {
	Animator anim;
	AudioSource sound;
	public Animator jaw;
	//public AudioClip[] clips;

	void Start () {
		anim = GetComponent<Animator> ();
		sound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (sound.isPlaying) {
			anim.SetBool ("Talking", true);
			jaw.SetBool ("Talking", true);
		} else {
			anim.SetBool ("Talking", false);
			jaw.SetBool ("Talking", false);
		}
	}
}
