using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Media;
public class AudioMano : MonoBehaviour {
	public AudioClip audioUno;
	public AudioClip audioDos;
	public AudioClip audioTres;
	public AudioClip audioCuatro;
	public AudioClip audioCinco;
	public AudioClip audioSeis;
	public AudioClip audioSiete;
	public AudioClip audioOcho;
	public AudioClip audioNueve;
	public AudioClip audioDiez;
	// Use this for initialization
	IEnumerator Start () {
		
		AudioSource audios = GetComponent< AudioSource> ();
//		audios.Play ();
		yield return new WaitForSeconds (audios.clip.length);
		audios.clip = audioUno;
		audios.Play ();


		Debug.Log ("hola");
		//audioDos = GetComponent<AudioSource>();
		//audioDos.Play ();
		//SoundPlayer sp= new SoundPlayer();
		//sp.SoundLocation = "";
		//sp.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
