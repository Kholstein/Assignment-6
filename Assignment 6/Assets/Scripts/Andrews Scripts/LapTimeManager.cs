using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

    public Text lapTimeText;
    public float lapTime = 0.0f;

    public Text DebugText;

    public float PlayerCount;
    bool lapComplete = false;

    public GameObject[] Players;

    private string FinalRecord;

    void Update()
    {   
        for(int i = 0; i < Players.Length; i++)
        {
            if(Players[i].GetComponent<PlayerController>().Finish)
            {
                lapComplete = true;
            }
        }

        if (lapComplete == false)
        {
            FormatLapTime(lapTime);
            lapTime += Time.deltaTime;
        }
        else
        {
            if (lapTime > PlayerPrefs.GetFloat("BestLapTime_1"))
            {
                PlayerPrefs.SetFloat("BestLapTime_1", lapTime);
                lapTimeText.text = "New Record!";
            }
        }
        Playercounter();
    }

    void FormatLapTime(float lapTimer)
    {
        string lapTimerString = lapTimer.ToString();
        lapTimeText.text = string.Format("{0}:{1:00}", (int)lapTimer / 60, (int)lapTimer % 60);
    }

    public void Playercounter()
    {
        DebugText.text = PlayerCount.ToString() + " Players in game";
    }
}
