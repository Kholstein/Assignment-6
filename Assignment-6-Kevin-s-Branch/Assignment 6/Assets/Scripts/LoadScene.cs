using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour 
{

	public string SceneName;

	public void LoadLevel()
	{
		SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
	}

	//you could branch this script into a bigger overarching GameController script, is what i reccomend doing anyway.

}
