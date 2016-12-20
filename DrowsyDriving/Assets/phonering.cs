using UnityEngine;
using System.Collections;

public class phonering : MonoBehaviour {

	public GameObject light;

	// Use this for initialization
	void Start () {
	
		StartCoroutine (ringing());
	}


	IEnumerator ringing()
	{
		yield return new WaitForSeconds (4);
		gameObject.GetComponent<AudioSource> ().Play ();
		light.SetActive (true);

	}

}
