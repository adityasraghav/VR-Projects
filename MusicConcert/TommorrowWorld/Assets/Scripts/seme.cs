using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class seme : MonoBehaviour, IPointerClickHandler {

	public GameObject medic, maincam;

	public void OnPointerClick(PointerEventData eventData)
	{
		maincam.GetComponent<Cam> ().isWalking = false;

		medic.GetComponent<Renderer> ().enabled = true;

		StartCoroutine (disappear ());


	}


	IEnumerator disappear()
	{
		yield return new WaitForSeconds (20);
		medic.GetComponent<Renderer> ().enabled = false;


	}
}