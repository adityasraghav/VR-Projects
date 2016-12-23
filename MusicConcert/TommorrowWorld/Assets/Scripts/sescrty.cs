using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class sescrty : MonoBehaviour, IPointerClickHandler {

	public GameObject security, maincam;

	public void OnPointerClick(PointerEventData eventData)
	{
		maincam.GetComponent<Cam> ().isWalking = false;
		security.GetComponent<Renderer> ().enabled = true;
		StartCoroutine (disappear ());

	}


	IEnumerator disappear()
	{
		yield return new WaitForSeconds (20);
		security.GetComponent<Renderer> ().enabled = false;

	}
}