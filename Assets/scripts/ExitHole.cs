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
		player.GetComponent<CharacterMotor>().enabled = false;
		player.GetComponent<FPSInputController>().enabled = false;

		Rigidbody body = player.AddComponent<Rigidbody>(); // Add the rigidbody.
//		yield return new WaitForSeconds(1);
		// this sound clip is 16hz delay n seconds
		audio.Play(16000 * 3);
//		yield return new WaitForSeconds(10);

		// wait for player to fall or something, then
		//Application.LoadLevel("SleighLand");
	}

}
