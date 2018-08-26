using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using AssemblyCSharp;

using System.Linq;
public class ApiRest : MonoBehaviour {
	//private	const string URL_estudiante="http://192.168.1.4/jsoftin/public/api/getRol";
	private	const string URL_pregunta="http://192.168.1.4/jsoftin/public/api/getRol";
	private	const string URL_respuesta="http://192.168.1.4/jsoftin/public/api/getRol";
	public  List<Rol> rolesList {get;set;}

	public List<Rol> ApiPregunta (){
		var request = new HttpWebRequest(new Uri(URL_pregunta));
		request.Timeout = 20000; //milliseconds
		request.Method = "GET";
		request.ContentType = "application/json";
		var response = request.GetResponse();
		var reader = new System.IO.StreamReader (response.GetResponseStream (), Encoding.UTF8);
		string responseString = reader.ReadToEnd();

		List<Rol> roles = JsonConvert.DeserializeObject<List<Rol>> (responseString);

		List<Rol> rol2 = new List<Rol> ();
		//Debug.Log (roles);
		foreach (var item in roles) {
			Rol r = new Rol ();
			r.id = item.id;
			r.rol = item.rol;
			r.created_at = item.created_at;
			r.updated_at = item.updated_at;
			rol2.Add (r);
		}

		//rolesList = rol2;
		return rol2;
	}
	public string getRolesPrimero(List<Rol> list){
		var roles = list.FirstOrDefault ();
		return roles.rol.ToString();
	}
}
