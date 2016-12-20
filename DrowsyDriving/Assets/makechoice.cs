using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class makechoice : MonoBehaviour {

	public GameObject a, b, c;
	public Animator anim;


	
	// Update is called once per frame
	void Update () {

		if (a.activeSelf && b.activeSelf && c.activeSelf) {
		
			if (CrossPlatformInputManager.GetButtonDown("Fire3"))
			{
				PlayerPrefs.SetInt("First Choice", 1);
				c.SetActive (false);
				StartCoroutine (delay (1f));
			}

			else if (CrossPlatformInputManager.GetButtonDown("Fire2"))
			{
				PlayerPrefs.SetInt("First Choice", 0);
				b.SetActive (false);
				StartCoroutine (delay (1f));
			}
		
		}
	
	}
	IEnumerator delay(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		anim.SetTrigger ("Fade");
		yield return new WaitForSeconds(1f);
		Application.LoadLevel (1);
	}
}
