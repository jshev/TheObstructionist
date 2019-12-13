using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class memorizeCountdown : MonoBehaviour {

	public Text countTxt;

	// other variables
	int numHitsRequired = 5;
	int numHits = 0;

	// Use this for initialization
	void Start () {
		// add a hit every second, starting on start
		InvokeRepeating ("CountDown", 1.0f, 1.0f);
		countTxt.text = "Countdown:   5";
		print (Application.loadedLevel);
	}
	
	// Update is called once per frame
	void Update () {
		if (numHits <= numHitsRequired) {
			countTxt.text = "Countdown:   " + (numHitsRequired - numHits);
		} else {
			Application.LoadLevel (Application.loadedLevel + 1);
		}
	}

	void CountDown() {
		numHits++;
	}
}
