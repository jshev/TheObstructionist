using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sliderController : MonoBehaviour {
	public Slider aShapeSlider;
	public Slider aColorSlider;
	public Slider aScaleSlider;
	public Slider aRotationSlider;

	public Slider bShapeSlider;
	public Slider bColorSlider;
	public Slider bScaleSlider;
	public Slider bRotationSlider;

	public Slider cShapeSlider;
	public Slider cColorSlider;
	public Slider cScaleSlider;
	public Slider cRotationSlider;

	// 3 sprites each
	public Sprite[] aSprites;
	public Sprite[] bSprites;
	public Sprite[] cSprites;

	// 9 possible colors
	Color[] colorOptions = {Color.white, Color.black, Color.blue, Color.cyan, Color.gray, 
		Color.green, Color.magenta, Color.red, Color.yellow};

	// 10 possible scales
	float[] scales = { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f, 1f };

	// 5 possible rotations
	int[] rotations = { 0, 45, 90, 135, 180 };

	public GameObject A;
	public GameObject B;
	public GameObject C;

	// Use this for initialization
	void Start () {
		A.GetComponent<SpriteRenderer> ().sprite = aSprites [0];
		A.GetComponent<SpriteRenderer> ().color = colorOptions [0];
		float scale = scales [4];
		A.transform.localScale = new Vector3(scale, scale, scale);
		float diff = rotations [0];
		A.transform.eulerAngles = new Vector3(
			A.transform.eulerAngles.x,
			A.transform.eulerAngles.y,
			diff
		);

		B.GetComponent<SpriteRenderer> ().sprite = bSprites [0];
		B.GetComponent<SpriteRenderer> ().color = colorOptions [0];
		B.transform.localScale = new Vector3(scale, scale, scale);
		B.transform.eulerAngles = new Vector3(
			B.transform.eulerAngles.x,
			B.transform.eulerAngles.y,
			diff
		);

		C.GetComponent<SpriteRenderer> ().sprite = cSprites [0];
		C.GetComponent<SpriteRenderer> ().color = colorOptions [0];
		C.transform.localScale = new Vector3(scale, scale, scale);
		C.transform.eulerAngles = new Vector3(
			C.transform.eulerAngles.x,
			C.transform.eulerAngles.y,
			diff
		);

		
	}

	// Update is called once per frame
	void Update () {

	}

	public void aShapeChange() {
		int value = (int) aShapeSlider.value;
		A.GetComponent<SpriteRenderer> ().sprite = aSprites [value];
	}

	public void aColorChange() {
		int value = (int) aColorSlider.value;
		A.GetComponent<SpriteRenderer> ().color = colorOptions [value];
	}

	public void aScaleChange() {
		int value = (int) aScaleSlider.value;
		float scale = scales [value];

		A.transform.localScale = new Vector3(scale, scale, scale);
	}

	public void aRotationChange() {
		int value = (int) aRotationSlider.value;
		float diff = rotations [value];

		A.transform.eulerAngles = new Vector3(
			A.transform.eulerAngles.x,
			A.transform.eulerAngles.y,
			diff
		);
	}



	public void bShapeChange() {
		int value = (int) bShapeSlider.value;
		B.GetComponent<SpriteRenderer> ().sprite = bSprites [value];
	}

	public void bColorChange() {
		int value = (int) bColorSlider.value;
		B.GetComponent<SpriteRenderer> ().color = colorOptions [value];
	}

	public void bScaleChange() {
		int value = (int) bScaleSlider.value;
		float scale = scales [value];

		B.transform.localScale = new Vector3(scale, scale, scale);
	}

	public void bRotationChange() {
		int value = (int) bRotationSlider.value;
		float diff = rotations [value];

		B.transform.eulerAngles = new Vector3(
			B.transform.eulerAngles.x,
			B.transform.eulerAngles.y,
			diff
		);
	}



	public void cShapeChange() {
		int value = (int) cShapeSlider.value;
		C.GetComponent<SpriteRenderer> ().sprite = cSprites [value];
	}

	public void cColorChange() {
		int value = (int) cColorSlider.value;
		C.GetComponent<SpriteRenderer> ().color = colorOptions [value];
	}

	public void cScaleChange() {
		int value = (int) cScaleSlider.value;
		float scale = scales [value];

		C.transform.localScale = new Vector3(scale, scale, scale);
	}

	public void cRotationChange() {
		int value = (int) cRotationSlider.value;
		float diff = rotations [value];

		C.transform.eulerAngles = new Vector3(
			C.transform.eulerAngles.x,
			C.transform.eulerAngles.y,
			diff
		);
	}

}