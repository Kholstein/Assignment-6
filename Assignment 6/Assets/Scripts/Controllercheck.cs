using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllercheck : MonoBehaviour {


	public GameObject XboxControls;
	public GameObject KeyboardControls;
	public GameObject PlaystationControls;
	private int Xbox_One_Controller = 0;
	private int PlaystationController = 0;

	void Update()
	{
	string[] names = Input.GetJoystickNames();
			for (int x = 0; x < names.Length; x++)
			{
				print(names[x].Length);
				if (names[x].Length == 33)
				{
					Xbox_One_Controller = 1;
				}
			else if (names[x].Length == 19)
				{
					PlaystationController = 1;
				}
			else 
			{
				Xbox_One_Controller = 0;
				PlaystationController = 0;
			}
			}
	
	
		if (Xbox_One_Controller == 1) {
			XboxControls.SetActive (true);
			KeyboardControls.SetActive (false);
			PlaystationControls.SetActive (false);
		} else if (PlaystationController == 1) {
			XboxControls.SetActive (false);
			KeyboardControls.SetActive (false);
			PlaystationControls.SetActive (true);

		}
		else
		{
			PlaystationControls.SetActive (false);
			XboxControls.SetActive(false);
			KeyboardControls.SetActive(true);
		}
	}
}
