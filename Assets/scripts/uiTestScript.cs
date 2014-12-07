using UnityEngine;
using System.Collections;

public class uiTestScript : MonoBehaviour {

	public GameObject sleigh;

	private Animator sleighAnim;
	private GameObject playButton;

// BUTTON CANT ACCESS THESE
	// Use this for initialization
	void Start () {

		playButton = GameObject.FindGameObjectWithTag("startButton");

		if (sleigh == null) {
			sleigh = gameObject;
		}
		sleighAnim = sleigh.GetComponent<Animator>();
		sleighAnim.enabled = false;


	}
	
	// Update is called once per frame
	void Update () {
		if (sleighAnim.GetCurrentAnimatorStateInfo(0).IsName("SleighRideOutside")) {
			//do nothing
		} else {
			Debug.Log("Done");
		}
	}

	public void clickTest (string text) { // (bool) (int) float or string
		Debug.Log (text);
		sleighAnim.enabled = true;
		Destroy(playButton);
		//playButton.renderer.enabled = false;  // doesnt work???
	}

	public void clickTest2 () {
		Debug.Log ("clicked 2");
		sleighAnim.enabled = true;
	}
}
