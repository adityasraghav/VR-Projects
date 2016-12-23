using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class sglass : MonoBehaviour, IPointerClickHandler {

	public GameObject maincam, begin, entry, brac;

	public void OnPointerClick(PointerEventData eventData)
	{
		maincam.GetComponent<Cam> ().isWalking = false;
		begin.SetActive (false);
		entry.GetComponent<Renderer> ().enabled = true;
		brac.GetComponent<Renderer> ().enabled = true;
		gameObject.SetActive(false);

	}
		
}

