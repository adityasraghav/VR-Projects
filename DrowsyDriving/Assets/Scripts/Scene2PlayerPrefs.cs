using UnityEngine;
using System.Collections;

public class Scene2PlayerPrefs : MonoBehaviour {
	public EyeLids el;
	public CarUserCtrl cuc;
	public CatAlive ca;
	public Animator StartScreen;
	public Sprite case1;
	public Sprite case2;
	public Camera cam;
	public Camera left;
	public Camera right;

	private int check;

	void Start () {
		cuc.enabled = false;
		check = PlayerPrefs.GetInt ("First Choice");
		if (check == 1) {
			// no sleep
			el.animate = true;
			cuc.delay = true;
			ca.sleepy = true;
			StartScreen.GetComponent<SpriteRenderer> ().sprite = case1;
		} else {
			el.animate = false;
			cuc.delay = false;
			ca.sleepy = false;
			StartScreen.GetComponent<SpriteRenderer> ().sprite = case2;
		}
		StartCoroutine (delay (6f));
	}

	IEnumerator delay(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		StartScreen.SetTrigger ("Start");
		cam.cullingMask = ~(1 << 8);
		left.cullingMask = ~(1 << 8);
		right.cullingMask = ~(1 << 8);
		cuc.enabled = true;
	}
}
