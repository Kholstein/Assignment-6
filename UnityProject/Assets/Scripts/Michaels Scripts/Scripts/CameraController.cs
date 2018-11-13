using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerMichael : MonoBehaviour {

	//object to look at
	/* 
	public Transform lookAt;

	//which camera is this
	public int camNumb = 0;
	//0 no player
	//1 1st Player
	//2 2st Player
	//3 3st Player
	//4 4st Player

	//Camera to transform -- Dont assign
	public Transform camTransform;

	private Camera cam;

	public int camNumCount = 0;

	//distance away from Player
	public float distance = 0f;

	//heigth above player
	public float height = 0f;
	//positioning
	private float currentX = 0f;
	private float currentY = 0f;
	//sensativity of movement
	private float sensivityX = 4f;
	private float sensivitY = 1f;

	private void Start()
	{
		cam = Camera.main;
		var camRect1 = new Rect (0.0f, 0.5f, 0.5f, 0.5f);
		var camRect2 = new Rect (0.5f, 0.5f, 0.5f, 0.5f);
		var camRect3 = new Rect (0.0f, 0.0f, 0.5f, 0.5f);
		var camRect4 = new Rect (0.5f, 0.0f, 0.5f, 0.5f);

		//referencing the player manager
		GameObject manager = GameObject.Find ("playerManager");
		playerSpawner playerSpawn = manager.GetComponent<playerSpawner> ();
		camNumb = playerSpawn.setCamNumber ();
		camNumCount = playerSpawn.setCamRectNumber ();
		camTransform = transform;
		if (camNumCount == 1) {
			cam.rect = camRect1;
		} else if (camNumCount == 2) {
			cam.rect = camRect2;
		} else if (camNumCount == 3) {
			cam.rect = camRect3;
		} else if (camNumCount == 4) {
			cam.rect = camRect4;
		}
	}


	private void Update()
	{
		//update X position -- Keyboard/Joystick
		//currentX += Input.GetAxis ("Horizontal");

		//update Y position -- Keyboard/Joystick
		//currentY += Input.GetAxis ("Vertical");

		//update X position -- Mouse X
		//currentX += Input.GetAxis ("Mouse X");

		//update Y position -- Mouse Y
		//currentY += Input.GetAxis ("Mouse Y");

		if (camNumb == 1)
		{
			//update X position -- Keyboard/Joystick
			currentX += Input.GetAxis ("P1_Horizontal");
		}
		else if(camNumb == 2)
		{
			//update X position -- Keyboard/Joystick
			currentX += Input.GetAxis ("P2_Horizontal");
		}
		else if(camNumb == 3)
		{
			//update X position -- Keyboard/Joystick
			currentX += Input.GetAxis ("P3_Horizontal");
		}
		else if(camNumb == 4)
		{
			//update X position -- Keyboard/Joystick
			currentX += Input.GetAxis ("P4_Horizontal");
		}	

	}

	private void LateUpdate()
	{
		Vector3 dir = new Vector3 (0, height, -distance);
		Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
		camTransform.position = lookAt.position + rotation * dir;

		camTransform.LookAt (lookAt.position);
	}
	*/
}
