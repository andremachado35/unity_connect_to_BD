using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;
using UnityEngine.Networking;
using UnityEngine.UI;

public class load_bd_2 : MonoBehaviour {
	void Start() {
		StartCoroutine(GetText());
	}

	IEnumerator GetText() {
		UnityWebRequest www = UnityWebRequest.Get("http://localhost/teste/exemplo.php?action=show_clientes");
		yield return www.SendWebRequest();

		if(www.isNetworkError || www.isHttpError) {
			Debug.Log(www.error);
		}
		else {
			// Show results as text
			Debug.Log(www.downloadHandler.text);
			//print(www.downloadHandler.text);
			string[] received_data = Regex.Split(www.downloadHandler.text,"</next>");
			int scores = (received_data.Length-1)/2;
			string a="";
			for(int i = 0; i<scores;i++) {
				a=a+"Código: "+received_data[2*i]+" Nome: "+received_data[2*i+1]+"\n";
			}
			Text texto=GetComponent<Text>();
			texto.text=a;
			// Or retrieve results as binary data
			//byte[] results = www.downloadHandler.data;

		}
	}
}

