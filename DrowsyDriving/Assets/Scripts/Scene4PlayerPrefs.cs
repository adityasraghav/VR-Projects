using UnityEngine;
using System.Collections;

public class Scene4PlayerPrefs : MonoBehaviour {
	public EyeLids el;
	public CarUserCtrl cuc;
	public ConstructionTrigger ct;
	public Animator StartScreen;
	public Sprite case3;
	public Sprite case4;
	public Camera cam;
	public Camera left;
	public Camera right;

	private int check;

	void Start () {
		cuc.enabled = false;
		check = PlayerPrefs.GetInt ("Second Choice");
		if (check == 1) {
			// no sleep
			el.animate = true;
			cuc.delay = true;
			ct.sleepy = true;
			StartScreen.GetComponent<SpriteRenderer> ().sprite = case3;
		} else {
			el.animate = false;
			cuc.delay = false;
			ct.sleepy = false;
			StartScreen.GetComponent<SpriteRenderer> ().sprite = case4;
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
