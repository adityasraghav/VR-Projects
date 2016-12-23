using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class stats : MonoBehaviour, IPointerClickHandler {

	public GameObject maincam;

	public void OnPointerClick(PointerEventData eventData)
	{

		gameObject.SetActive (false);
		maincam.GetComponent<Cam> ().isWalking = false;

	}

}
