using UnityEngine;
using System.Collections;

public class ExitHole : MonoBehaviour {

	private bool  isExiting			= false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	void OnCollisionEnter(Collision col) {
//		if (col.gameObject.CompareTag ("Player")) {
//			Debug.Log ("Hit the Hole!");
//		}
//	}
	void OnTriggerEnter(Collider other) {
		if (!isExiting && other.CompareTag ("Player")) {
			print ("Hit the Hole!");

//			GameObject playerObj = other.gameObject;
//			Rigidbody rigid = playerObj.AddComponent<Rigidbody>();
//			rigid.useGravity = true;
			isExiting = true;

			// wait for player to fall or something, then
			Application.LoadLevel("SleighLand");
		}
	}
}
