using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarColision : MonoBehaviour {

	public GameObject musica;
	void OnTriggerEnter(Collider other){
		Debug.Log (other.bounds);
		Debug.Log (other.gameObject);
		Debug.Log (other.gameObject.tag);
		if(other.gameObject.tag=="Player"){
			//activar y desactivar los checkbox de ualquier objet en ecena
			musica.SetActive(true);
			var a = other.GetComponentInChildren (typeof(MeshCollider));
			//Debug.Log (a.sharedMesh.);
			Debug.Log (other.GetComponentInChildren(typeof(MeshCollider)));
			//ccollider
		}
	}
	//void OnCollisionEnter(Collider other){
	//	Debug.Log ("colision enter "+other);
	//}

	//void OnColliderStay (Collider other){
	//	Debug.Log ("colision stay "+other);
	//}
}
