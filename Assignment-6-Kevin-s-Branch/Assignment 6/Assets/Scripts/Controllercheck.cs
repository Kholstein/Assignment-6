using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllercheck : MonoBehaviour {


	public GameObject XboxControls;
	public GameObject KeyboardControls;
	private int Xbox_One_Controller = 0;

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
				else
				{
					Xbox_One_Controller = 0;
				}
			}
	
	
	if(Xbox_One_Controller == 1)
	{
		XboxControls.SetActive(true);
		KeyboardControls.SetActive(false);
	}
	else
	{
		XboxControls.SetActive(false);
		KeyboardControls.SetActive(true);
	}
	}
}
