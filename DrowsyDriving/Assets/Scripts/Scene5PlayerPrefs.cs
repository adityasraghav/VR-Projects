using UnityEngine;
using System.Collections;

public class Scene5PlayerPrefs : MonoBehaviour {
	public Scene5Animator sa;
	private int check;

	void Start () {
		check = PlayerPrefs.GetInt ("Second Choice");
		if (check == 1) {
			sa.sleepy = true;
		} else {
			sa.sleepy = false;
		}
	}
}
