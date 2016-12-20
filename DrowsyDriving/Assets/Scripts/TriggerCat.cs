using UnityEngine;
using System.Collections;

public class TriggerCat : MonoBehaviour {
	public GameObject cat;
	public AudioSource sound;
	public AudioClip clip;
	public catMovement cm;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			//cat.SetActive (true);
			cm.letGo = true;
			sound.clip = clip;
			sound.pitch = 1.15f;
			sound.Play ();
		}

	}
}
