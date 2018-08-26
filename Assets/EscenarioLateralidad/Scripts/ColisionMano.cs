using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColisionMano : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("test mano "+other);
		Debug.Log ("test mano "+other.gameObject.name);
		if(other.gameObject.name=="ManoIzquierda"){
			Debug.Log ("Tocaste con la mano izquierda");
		}
		if(other.gameObject.name=="ManoDerecha"){
			Debug.Log ("Tocaste con la mano derecha");
		}
		// start the animation clip
		Animation animation = gameObject.GetComponent<Animation>();
		if(animation != null && !animation.isPlaying)
		{
			animation.Play();
		}

		// play the audio clip
		AudioSource audioSrc = gameObject.GetComponent<AudioSource>();
		if(audioSrc != null && !audioSrc.isPlaying)
		{
			audioSrc.Play();
			Servicio s = new Servicio ();
			Debug.Log(s.GetRest ());
			Debug.Log ("No entro");
		}


	}
}
