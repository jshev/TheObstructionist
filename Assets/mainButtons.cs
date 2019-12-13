using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainButtons : MonoBehaviour {

	public void play() {
		SceneManager.LoadScene ("Scene1");
	}

	public void menu() {
		SceneManager.LoadScene ("Menu");
	}
}