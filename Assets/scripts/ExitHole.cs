using UnityEngine;
using System.Collections;

public class ExitHole : MonoBehaviour {

	private bool  isExiting			= false;
	private float distance;
	private GameObject[] exitHoles;
	private GameObject player;


	// Use this for initialization
	void Start () {
		exitHoles = GameObject.FindGameObjectsWithTag("exitHole");
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (!isExiting) {
			foreach(GameObject exitHole in exitHoles) {
				distance = Vector3.Distance( exitHole.transform.position, player.transform.position );
				if (distance < 2) {
					ExitGingerLand();
				}
//				Debug.Log (distance);
			}
		}
	}

	private void ExitGingerLand() {
		isExiting = true;

		// disable player scripts
		if (player.GetComponent<CharacterMotor>())
			player.GetComponent<CharacterMotor>().enabled = false;
		if (player.GetComponent<FPSInputController>())
			player.GetComponent<FPSInputController>().enabled = false;
		if (player.GetComponent<OVRPlayerController>())
			player.GetComponent<OVRPlayerController>().enabled = false;

		Rigidbody body = player.AddComponent<Rigidbody>(); // Add the rigidbody.
//		yield return new WaitForSeconds(1);

		audio.PlayDelayed(3);

//		yield return new WaitForSeconds(10);

		// wait for player to fall or something, then
		//Application.LoadLevel("SleighLand");
	}

}
