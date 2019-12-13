using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recreateCountdown : MonoBehaviour {


	Vector3 screenPoint;
	Vector3 offset;

	public Text countTxt;
	public GameObject aPanel;
	public GameObject bPanel;
	public GameObject cPanel;

	// other variables
	int numHitsRequired = 45;
	int numHits = 0;

	// Use this for initialization
	void Start () {
		// add a hit every second, starting on start
		InvokeRepeating ("CountDown", 1.0f, 1.0f);
		countTxt.text = "Countdown:   45";
		print (Application.loadedLevel);
	}
	
	// Update is called once per frame
	void Update () {
		if (numHits <= numHitsRequired) {
			countTxt.text = "Countdown:   " + (numHitsRequired - numHits);
		} else {
			Application.LoadLevel (Application.loadedLevel + 1);
		}

		if (Input.GetMouseButtonDown(0)) {
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			if (hit.collider != null) {
				print ("clicked");
				if (hit.transform.tag == "A") {
					print ("A");
					aPanel.SetActive (true);
					bPanel.SetActive (false);
					cPanel.SetActive (false);
				} else if (hit.transform.tag == "B") {
					print ("B");
					aPanel.SetActive (false);
					bPanel.SetActive (true);
					cPanel.SetActive (false);
				} else if (hit.transform.tag == "C") {
					print ("C");
					aPanel.SetActive (false);
					bPanel.SetActive (false);
					cPanel.SetActive (true);
				}
			}
		}
	}

	void CountDown() {
		numHits++;
	}
}
