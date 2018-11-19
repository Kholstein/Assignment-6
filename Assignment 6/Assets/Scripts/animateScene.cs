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
	public void Animation () 
	{
		anim.Play ("fadeToBlack");
	}
}
