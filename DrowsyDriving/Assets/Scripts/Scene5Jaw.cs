using UnityEngine;
using System.Collections;

public class Scene5Jaw : MonoBehaviour {
	AudioSource sound;
	public Animator jaw;

	void Start () {
		sound = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if (sound.isPlaying) {
			jaw.SetBool ("Talking", true);
		} else {
			jaw.SetBool ("Talking", false);
		}
	}
}
