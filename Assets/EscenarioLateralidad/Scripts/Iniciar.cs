using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AssemblyCSharp;
public class Iniciar : MonoBehaviour {
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
	void Start () {
		AudioPlay ();



		ApiRest a = new ApiRest ();
		List<Rol> rol2 = a.ApiPregunta ();
		Debug.Log("iniciar "+a.getRolesPrimero(rol2));



	}
	IEnumerator AudioPlay(){
		AudioSource audios = GetComponent< AudioSource> ();
		yield return new WaitForSeconds (audios.clip.length);
		audios.clip = audioUno;
		audios.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
