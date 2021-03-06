using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Victory : MonoBehaviour {
	public static int firstPlace = 0;
	public static int secondPlace = 0;
	public static int thirdPlace = 0;
	public static int fourthPlace = 0;
	public GameObject first;
	public GameObject second;
	public GameObject third;
	public GameObject fourth;
	public Material material1;
	public Material material2;
	public Material material3;
	public Material material4;

	// Use this for initialization
	void Start () {
		if (firstPlace == 1) {
			first.GetComponent<MeshRenderer> ().material = material1;
		}
		if (firstPlace == 2) {
			first.GetComponent<MeshRenderer> ().material = material2;
		}
		if (firstPlace == 3) {
			first.GetComponent<MeshRenderer> ().material = material3;
		}
		if (firstPlace == 4) {
			first.GetComponent<MeshRenderer> ().material = material4;
		}
		if (secondPlace == 1) {
			second.GetComponent<MeshRenderer> ().material = material1;
		}
		if (secondPlace == 2) {
			second.GetComponent<MeshRenderer> ().material = material2;
		}
		if (secondPlace == 3) {
			second.GetComponent<MeshRenderer> ().material = material3;
		}
		if (secondPlace == 4) {
			second.GetComponent<MeshRenderer> ().material = material4;
		}
		if (thirdPlace == 1) {
			third.GetComponent<MeshRenderer> ().material = material1;
		}
		if (thirdPlace == 2) {
			third.GetComponent<MeshRenderer> ().material = material2;
		}
		if (thirdPlace == 3) {
			third.GetComponent<MeshRenderer> ().material = material3;
		}
		if (thirdPlace == 4) {
			third.GetComponent<MeshRenderer> ().material = material4;
		}
		if (fourthPlace == 1) {
			fourth.GetComponent<MeshRenderer> ().material = material1;
		}
		if (fourthPlace == 2) {
			fourth.GetComponent<MeshRenderer> ().material = material2;
		}
		if (fourthPlace == 3) {
			fourth.GetComponent<MeshRenderer> ().material = material3;
		}
		if (fourthPlace == 4) {
			fourth.GetComponent<MeshRenderer> ().material = material4;
		}
		firstPlace = 0;
		secondPlace = 0;
		thirdPlace = 0;
		fourthPlace = 0;
		Invoke ("returnToMenu", 8);
	}

	public void returnToMenu() {
		SceneManager.LoadScene("MainMenu");
	}
}
