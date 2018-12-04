using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuAnimation : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	public void playCreditsAnimation() {
		anim.SetTrigger ("CreditsButton");
	}

	public void playCreditsBackAnimation() {
		anim.SetTrigger ("BackButtonCredits");
	}
}
