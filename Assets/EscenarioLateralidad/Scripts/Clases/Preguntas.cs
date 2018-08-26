using UnityEngine;
using System.Collections;

public class Preguntas : MonoBehaviour
{	
	[System.Serializable]
	public class Pregunta
	{
		public int id { get; set;}	
		public string rol { get; set;}		
		//public DateTime created_at { get; set;}	
		//public DateTime updated_at { get; set;}	
	}
}

