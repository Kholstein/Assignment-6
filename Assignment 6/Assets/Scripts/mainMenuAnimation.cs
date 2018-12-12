using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuAnimation : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
		anim = GetComponent<Animator> ();
	}
	public void playCreditsAnimation() {
		anim.SetTrigger ("CreditsButton");
	}

	public void playCreditsBackAnimation() {
		anim.SetTrigger ("BackButtonCredits");
	}
	public void playStartAnimation() {
		anim.SetTrigger ("StartButton");
	}
	public void playStartBackAnimation() {
		anim.SetTrigger ("BackButtonStart");
	}
	public void playControlsAnimation() {
		anim.SetTrigger ("ControlsButton");
	}
	public void playControlsBackAnimation() {
		anim.SetTrigger ("BackButtonControls");
	}
}
