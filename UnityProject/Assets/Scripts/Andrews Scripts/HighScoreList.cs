//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.UI;

//public class HighScoreList : MonoBehaviour {

//    public Text[] playerNameText;
//    public Text[] lapTimeText;
//    public Scene level;
//    public LapTimeManager lapTimeManager;
    
//    void Awake()
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            playerNameText[i].GetComponent<Text>();
//            lapTimeText[i].GetComponent<Text>();
//        }
//        level = SceneManager.GetActiveScene();
//    }

//    void Update()
//    {
//        string currentLevel = level.name;
//        for (int i = 1; i <= 5; i++)
//        {
//            float lapTime = PlayerPrefs.GetFloat("BestLapTime_" + currentLevel + i.ToString());
//            string lapTimeFormatted = lapTimeManager.FormatLapTime(lapTime);
//            lapTimeText[(i-1)].text = lapTimeFormatted;

//            playerNameText[(i-1)].text = PlayerPrefs.GetString("PlayerName_" + currentLevel + i.ToString());
//        }
//    }
//}
