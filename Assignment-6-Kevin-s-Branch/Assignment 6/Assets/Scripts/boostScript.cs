using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostScript : MonoBehaviour {
	public float boostValue;
	//public GameObject boosterSelf;
	//Vector3 forwardVector;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter(Collider other) {
//		forwardVector = boosterSelf.transform.TransformVector (0,0,0);

//		Vector3 forwardVector = this.gameObject.transform.TransformDirection(0,0,1);
//		forwardVector = this.gameObject.transform.TransformVector (0, 0, 0);
		other.attachedRigidbody.AddForce(gameObject.transform.forward * boostValue, ForceMode.Impulse);
	}
}
