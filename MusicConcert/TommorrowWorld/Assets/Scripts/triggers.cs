using UnityEngine;
using System.Collections;

public class triggers : MonoBehaviour {

	public AudioSource a, b, c, d, e, f;
	public GameObject l, ef;
	public GameObject maincam;

	public GameObject bracelet, entry, dreamville, tickets, revenue, eventt, eventt1, eventt2, mainstg, aoki, cake, effects, lights, cakeface;

	public GameObject brac, hb, dv, tick, rev, ei, ms, me, ab, fl, crowd, kart, begn;

	// Use this for initialization

	void Start () {
    }

    void Update() {
        
    }


	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
	
		if (other.gameObject == brac)
		{
			other.gameObject.SetActive (false);
			bracelet.SetActive (false);
			entry.SetActive (false);

		}

		if (other.gameObject == hb)
		{
			other.gameObject.SetActive (false);
		}

		if (other.gameObject == dv)
		{
			other.gameObject.SetActive (false);
			dreamville.GetComponent<Renderer> ().enabled = true;
			maincam.GetComponent<Cam> ().isWalking = false;
		}

		if (other.gameObject == tick)
		{
			other.gameObject.SetActive (false);
			tickets.GetComponent<Renderer> ().enabled = true;
			maincam.GetComponent<Cam> ().isWalking = false;
			dreamville.SetActive (false);
		}

		if (other.gameObject == rev)
		{
			other.gameObject.SetActive (false);
			revenue.GetComponent<Renderer> ().enabled = true;
			maincam.GetComponent<Cam> ().isWalking = false;
			tickets.SetActive (false);
		}

		if (other.gameObject == ei)
		{
			other.gameObject.SetActive (false);
			eventt.GetComponent<Renderer> ().enabled = true;
			eventt1.GetComponent<Renderer> ().enabled = true;

			maincam.GetComponent<Cam> ().isWalking = false;
			revenue.SetActive (false);
		}

		if (other.gameObject == ms)
        {
            cakeface.SetActive(false);
            other.gameObject.SetActive (false);
			mainstg.GetComponent<Renderer> ().enabled = true;
			maincam.GetComponent<Cam> ().isWalking = false;
			eventt.SetActive (false);
			eventt1.SetActive (false);
			eventt2.SetActive (false);
		}

		if (other.gameObject == me)
		{
			other.gameObject.SetActive (false);
			kart.SetActive (false);
			mainstg.SetActive (false);
			begn.SetActive (false);
			crowd.SetActive (true);
		}

		if (other.gameObject == ab)
		{
			other.gameObject.SetActive (false);
			maincam.GetComponent<Cam> ().isWalking = false;
			effects.SetActive (false);
			lights.SetActive (false);
			a.Stop ();
			b.Stop ();
			c.Stop ();
			d.Stop ();
			StartCoroutine (finisher());

		}

		if (other.gameObject == fl)
		{
			other.gameObject.SetActive (false);
			maincam.GetComponent<Cam> ().isWalking = false;
			maincam.GetComponent<Cam> ().check = 1;

            StartCoroutine(cakethrow());
        }

	}


    IEnumerator cakethrow()
    {

        yield return new WaitForSeconds(3);
        cakeface.SetActive(true);
        iTween.MoveTo(cakeface, iTween.Hash("path", iTweenPath.GetPath("cakePath"), "time", 2));

    }

    IEnumerator finisher()
	{
		e.Play ();
		f.Play ();
		yield return new WaitForSeconds (4);
		c.Play ();
		d.Play ();
		yield return new WaitForSeconds (5);
		l.SetActive (true);
		ef.SetActive (true);
	}

    


}
