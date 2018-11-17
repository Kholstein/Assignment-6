using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateScene : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//debug
		if (PlayerController.finishNumber == 1) {
			anim.SetTrigger ("finishRace");
		}
		if (PlayerController.finishNumber == 4) {
			anim.SetTrigger ("finishRace");
		}
	}
}
