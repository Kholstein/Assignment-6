using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class DebugTeleport: MonoBehaviour 
{

	public void Update ()
	{
		if (Input.GetKeyDown(KeyCode.F12))
		{
			SceneManager.LoadScene("Debug", LoadSceneMode.Single);
		}
	}


}
