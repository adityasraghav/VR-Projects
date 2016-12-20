using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class pickphone : MonoBehaviour
{ 

	public GameObject a, b, c;

	public void runfunc()
	{

		RaycastHit hit;

		if (Physics.Raycast(Cardboard.SDK.GetComponentInChildren<CardboardHead>().Gaze, out hit))
		{
			//print (hit.collider.name);
			if (hit.collider.name.Contains("iPhone"))
			{
				a.SetActive(true);
				b.SetActive(true);
				c.SetActive(true);
			}
		}
	}

	void Update () {

		if (CrossPlatformInputManager.GetButtonDown("Fire1"))
		{
			//print ("x was pushed");
			runfunc();
		}
	}
}

// fire 3 is left fire 2 is right