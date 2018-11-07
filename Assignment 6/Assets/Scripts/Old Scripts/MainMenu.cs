using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuMichael : MonoBehaviour {

	public int Players = 0;

	//clicity button
	public void Click()
	{
		//SceneManager.LoadScene("LevelSelect");
		if (Players == 0)
		{
			//Do Nothing
		}
		else if (Players == 1)
		{
			SceneManager.LoadScene("Level01_1");
		}
		else if (Players == 2)
		{
			SceneManager.LoadScene("Level01_2");
		}
		else if (Players == 3)
		{
			SceneManager.LoadScene("Level01_3");
		}
		else if (Players == 4)
		{
			SceneManager.LoadScene("Level01_4");
		}
	}

	public void QuitGame()
	{
		Debug.Log("You Have Stopped The Program!");
		Application.Quit ();
	}

	public void Set0 ()
	{
		Debug.Log("No Players");
		Players = 0;
	}

	public void Add1 ()
	{
		Debug.Log("Single Player");
		Players = 1;
	}

	public void Add2 ()
	{
		Debug.Log("Two Player");
		Players = 2;
	}

	public void Add3 ()
	{
		Debug.Log("Three Player");
		Players = 3;
	}

	public void Add4 ()
	{
		Debug.Log("Four Player");
		Players = 4;
	}
}
