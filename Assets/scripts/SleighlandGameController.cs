using UnityEngine;
using System.Collections;

public class SleighlandGameController : MonoBehaviour {

	public GameObject sleigh;

	private Animator sleighAnim;
	private GameObject startButton;
	private bool isPlaying;

// BUTTON CANT ACCESS THESE
	// Use this for initialization
	void Start () {

		isPlaying = false;

		startButton = GameObject.FindGameObjectWithTag("startButton");

		if (sleigh == null) {
			sleigh = gameObject;
		}
		sleighAnim = sleigh.GetComponent<Animator>();
		sleighAnim.enabled = false;


	}
	
	// Update is called once per frame
	void Update () {
		if (isPlaying) {
			if (sleighAnim.GetCurrentAnimatorStateInfo(0).IsName("SleighRideOutside")) {
				//do nothing
			} else {
				Debug.Log("Done");
				// show Enter button and wait
				ClickEnterGingerButton();
			}
		}
	}

	public void ClickStartButton () {
		Debug.Log ("clicked Start");
		sleighAnim.enabled = true;
		//startButton.renderer.enabled = false;  // doesnt work???
		Destroy(startButton);
		//startButton.gameObject.SetActive(false);
		isPlaying = true;
	}

	public void ClickEnterGingerButton () {
		Debug.Log ("clicked Enter");
		Application.LoadLevel("GingerLand");
	}

//	private void ClickMuteButton () {
//		sleigh.audio.mute = !sleigh.audio.mute;
//		//toggle text "Mute" vs "Un-Mute"
//	}

}
