using UnityEngine;
using System.Collections;

public class ExitHole : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("Player")) {
			Debug.Log ("Hit the Hole!");
		}
	}
}
