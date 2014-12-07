﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject sleigh;
	public GUISkin customSkin;
	
	private float buttonW 			= 100;
	private float buttonH 			= 50;
	private float halfScreenW;
	private float halfButtonW;

	private bool  isRunning			= false;


	// Use this for initialization
	void Start () {
		halfScreenW = Screen.width/2;
		halfButtonW = buttonW/2;

		if (sleigh.animation.playAutomatically)
			print ("Plays automatically");
		else
			print ("Should not play automatically");

		//ShowStartPrompt();

		// pg 444
//		yield WaitForSeconds( 3); 
//		Application.LoadLevel( 0); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	private void OnGUI() {
		GUI.skin = customSkin;
		
		MuteButton ();

		if (!isRunning) {
			if (GUI.Button (new Rect(halfScreenW-halfButtonW, 460, buttonW, buttonH), "Start")) {
				isRunning = true;
			}
		}

		if (!sleigh.animation.isPlaying) {
			if (GUI.Button (new Rect(0, 150, 100, 50), "Enter")) {
				Application.LoadLevel("GingerLand");
			}
		}
	}
	
	private void MuteButton () {
		if (GUI.Button (new Rect(10, 10, 70, 50), "Mute")) {
			if (sleigh.audio.mute)
				sleigh.audio.mute = false;
			else
				sleigh.audio.mute = true;
		}
	}
}
