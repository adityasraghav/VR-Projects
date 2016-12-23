using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class seco : MonoBehaviour, IPointerClickHandler {

	public GameObject countries, maincam;

	public void OnPointerClick(PointerEventData eventData)
	{
		maincam.GetComponent<Cam> ().isWalking = false;

		countries.GetComponent<Renderer> ().enabled = true;

		StartCoroutine (disappear ());


	}


	IEnumerator disappear()
	{
		yield return new WaitForSeconds (20);
		countries.GetComponent<Renderer> ().enabled = false;


	}
}
