using UnityEngine;
using System.Collections;

public class ExitHole : MonoBehaviour {

	private bool  isExiting			= false;
	private float distance;
	private GameObject exitHole;
	private GameObject player;


	// Use this for initialization
	void Start () {
		exitHole = GameObject.FindGameObjectWithTag("exitHole");
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance( exitHole.transform.position, player.transform.position );
		if (distance < 2) {
			ExitGingerLand();
		}
		Debug.Log (distance);
	}

	private void ExitGingerLand() {
		isExiting = true;
		// wait for player to fall or something, then
		Application.LoadLevel("SleighLand");
	}

}
