using UnityEngine;
using System.Collections;

public class checker : MonoBehaviour {

	public int check;
	// Use this for initialization
	void Start () {
	

		check = PlayerPrefs.GetInt ("First Choice");
	}
	
	// Update is called once per frame
	void Update () {
	
		if (check == 1) {

			gameObject.SetActive (false);
		}
			

	}
}
