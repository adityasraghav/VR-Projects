using UnityEngine;
using System.Collections;

public class CarCollision : MonoBehaviour {
	public int numOfCollisions = 0;
    //public GameObject instr;
    //public AudioClip clip;
    //private AudioSource speak;
	private AudioSource crash;

	void Start () {
		crash = GetComponent<AudioSource> ();
        //speak = instr.GetComponent<AudioSource>();
	}
	
	void OnCollisionEnter (Collision col) {
		crash.Play ();
		++numOfCollisions;
        //speak.clip = clip;
        //speak.Play();
	}
}
