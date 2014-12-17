using UnityEngine;
using System.Collections;

public class SleighlandGameController : MonoBehaviour {

	public GameObject sleigh;

	private Animator sleighAnim;
	private GameObject startButton;
	private GameObject enterButton;
	private GameObject quitButton;
	private GameObject building;
	private float distance;

//	private bool isPlaying;

// BUTTON CANT ACCESS THESE
	// Use this for initialization
	void Start () {

//		isPlaying = false;

		startButton = GameObject.FindGameObjectWithTag("startButton");
		enterButton = GameObject.FindGameObjectWithTag("enterButton");
		quitButton  = GameObject.FindGameObjectWithTag("quitButton");
		building    = GameObject.FindGameObjectWithTag("endLocation");

		if (enterButton != null)
			enterButton.SetActive(false);

		if (sleigh == null) {
			sleigh = gameObject;
		}
		sleighAnim = sleigh.GetComponent<Animator>();
		sleighAnim.enabled = false;


	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.anyKey) {
//			ClickStartButton();
//		} 
//		else {

			distance = Vector3.Distance(building.transform.position, gameObject.transform.position);
			Debug.Log (distance);
//			if (distance <= 4.1 && enterButton != null) {
//				enterButton.SetActive (true);
//			}
			if (distance <= 1.5)
				ClickEnterGingerButton();
//		}
	}

	public void ClickStartButton () {
		//Debug.Log ("clicked Start");
		sleighAnim.enabled = true;
		//startButton.renderer.enabled = false;  // doesnt work???
		//Destroy(startButton);
		startButton.SetActive(false);
		quitButton.SetActive(false);
		//startButton.gameObject.SetActive(false);
//		isPlaying = true;
	}

	public void ClickEnterGingerButton () {
		//Debug.Log ("clicked Enter");
		Application.LoadLevel("GingerLand");
	}

	public void ClickQuitButton () {
		Debug.Log("Quit pressed");
		Application.Quit ();
	}

//	private void ClickMuteButton () {
//		sleigh.audio.mute = !sleigh.audio.mute;
//		//toggle text "Mute" vs "Un-Mute"
//	}

//	/*
//	 * toggleOVR(bool ovr)
//	 * 	if ovr
//	 * 		disable Sleigh.Camera
//	 * 		enable Sleigh.OVRPalyerController
//	 * 		disable OverlayCanvas
//	 * 		enable World Canvas ?
//	 * 		in GingerLand scene, disable 
//	 * 			disable "main First Person Controller"
//	 * 			enable OVRPlayerController
//	 * /

}
