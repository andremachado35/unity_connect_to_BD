using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class load_bd : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		string url = "http://localhost/teste/exemplo.php?action=show_clientes";
		using (WWW w = new WWW(url))
		{ yield return w;
		  print(w.text);
			string[] received_data = Regex.Split(w.text,"</next>");
			int scores = (received_data.Length-1)/2;
			string a="";
			for(int i = 0; i<scores;i++) {
				a=a+"Código: "+received_data[2*i]+" Nome: "+received_data[2*i+1]+"\n";
			}
		  Text texto=GetComponent<Text>();
		  texto.text=a;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
