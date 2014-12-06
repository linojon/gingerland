using UnityEngine;
using System.Collections;

public class TitleGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnGUI() {
		if (GUI.Button (new Rect(0, 0, 100, 50), "Start")) {
			print ("You clicked me");
		}
		if (GUI.Button (new Rect(0, 150, 100, 50), "Enter")) {
			Application.LoadLevel(1);
		}
	}
}
