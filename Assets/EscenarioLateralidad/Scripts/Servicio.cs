using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Net;
using System.Text;
using System;
using System.IO;
using Newtonsoft.Json;
using UB.SimpleCS.Models;
using UnityEngine.Networking;
using AssemblyCSharp;

public class Servicio :MonoBehaviour {

	private	const string URL="http://192.168.1.4/jsoftin/public/api/getRol";
	//private const string API_KEY = "28ce99b04832b5c4e3a2afa11858f391";
	public Text responseText;

	public string GetRest(){
		var request = new HttpWebRequest(new Uri(URL));
		request.Timeout = 20000; //milliseconds
		request.Method = "GET";
		request.ContentType = "application/json";
		var response = request.GetResponse();
		var reader = new System.IO.StreamReader (response.GetResponseStream (), Encoding.UTF8);
		string responseString = reader.ReadToEnd();



		List<Rol> roles = JsonConvert.DeserializeObject<List<Rol>> (responseString);
		//Debug.Log (roles);
		foreach (var item in roles) {
			Debug.Log (item.rol);
		}
		return responseString;


	}




	}

