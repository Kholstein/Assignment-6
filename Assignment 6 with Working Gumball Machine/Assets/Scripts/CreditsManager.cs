using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsManager : MonoBehaviour 
{
	// takes 2 canvas objects and basically is like a light switch. Has an off/on button(s). Idk how you will implement it, but do what you wanna do.
	public GameObject Credits;
	public GameObject Menu;

	public void ShowCredits()
	{
		Credits.SetActive(true);
		Menu.SetActive(false);
	}

	public void HideCredits()
	{
		Credits.SetActive(false);
		Menu.SetActive(true);
	}

}
