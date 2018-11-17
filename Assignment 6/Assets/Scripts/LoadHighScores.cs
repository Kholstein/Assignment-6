using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadHighScores : MonoBehaviour 
{

	public Text HighscoreText;

	//public string HighscoreLevelName;

	public void OnClick()
	{
		HighscoreText.text = string.Format("{0}:{1:00}", (int)PlayerPrefs.GetFloat("BestLapTime_1") / 60, (int)PlayerPrefs.GetFloat("BestLapTime_1") % 60);
		//HighscoreText.text = string.Format("{0}:{1:00}", (int)PlayerPrefs.GetFloat("HighscoreLevelName") / 60, (int)PlayerPrefs.GetFloat("HighscoreLevelName") % 60);
		//This is just set for the Debug Level, but with the commented out stuff this will work just fine for everything else.
	}

}
