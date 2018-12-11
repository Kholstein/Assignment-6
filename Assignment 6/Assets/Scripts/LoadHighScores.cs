using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadHighScores : MonoBehaviour 
{
    public Scene level;
    public Text[] playerNameText;
    public Text[] lapTimeText;
    //public Text HighscoreText;

    public string factoryLevel = "failureFactory";
    public string quarryLevel = "Hectic Highway";

    void Awake()
    {
        for (int i = 0; i < 10; i++)
        {
            playerNameText[i].GetComponent<Text>();
            lapTimeText[i].GetComponent<Text>();
        }
        level = SceneManager.GetActiveScene();
    }

    public void OnClick()
	{
        string currentLevel = level.name;
        for (int i = 1; i <= 10; i++)
        {
            if (i < 6)
            {
                float lapTime = PlayerPrefs.GetFloat("BestLapTime_" + factoryLevel + i.ToString());
                string lapTimeFormatted = FormatLapTime(lapTime);
                lapTimeText[(i - 1)].text = lapTimeFormatted;

                playerNameText[(i - 1)].text = PlayerPrefs.GetString("PlayerName_" + factoryLevel + i.ToString());
            }
            else
            {
                float lapTime = PlayerPrefs.GetFloat("BestLapTime_" + quarryLevel + (i - 5).ToString());
                string lapTimeFormatted = FormatLapTime(lapTime);
                lapTimeText[(i - 1)].text = lapTimeFormatted;

                playerNameText[(i - 1)].text = PlayerPrefs.GetString("PlayerName_" + quarryLevel + (i - 5).ToString());
            }
        }
    }

    public string FormatLapTime(float lapTimer)
    {
        int minutes = (int)lapTimer / 60;
        int seconds = (int)lapTimer % 60;
        float milliseconds = lapTimer * 1000;
        milliseconds = milliseconds % 1000;

        string lapTimerString = lapTimer.ToString();
        lapTimerString = string.Format("{0}:{1:00}.{2:000}", minutes, seconds, milliseconds);
        return lapTimerString;
    }

}
