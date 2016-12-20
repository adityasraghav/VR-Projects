using UnityEngine;
using System.Collections;

public class catMovement : MonoBehaviour {
	Animator anim;

	private Rigidbody rb;
	public float movementSpeed = 5.0f;
	public float speed = 2;
	public int maxX = -30;
	private bool alreadyRunning = false;
	public bool notDead = true;
	private AudioSource sound;
	public AudioSource emma;
	public AudioClip clip;
	public bool letGo = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent <Animator> ();
		//anim.SetTrigger ("isIdle");
		sound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (letGo) {
			if (!alreadyRunning) {
				anim.SetTrigger ("isRunning");
				alreadyRunning = true;
			}
			if (transform.localPosition.x < maxX && notDead) {
				transform.position += Vector3.left * Time.deltaTime * movementSpeed;
				//rb.AddForce(Vector3.left * speed);

			} else {
				anim.SetTrigger ("isHit");

			}
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			notDead = false;
			rb.isKinematic = true;
			rb.angularVelocity = Vector3.zero;
			rb.velocity = Vector3.zero;
			transform.rotation = Quaternion.Euler (0, 270, 270);
			anim.SetTrigger ("isHit");
			sound.Play ();
			emma.clip = clip;
			emma.pitch = 1.05f;
			StartCoroutine ("delay", 1f);
		}

	}

	IEnumerator delay(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		emma.Play ();
	}
}	