using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

   public Text lapTimeText;
   public float lapTime = 0.0f;
   string lapTimeString;
   public bool lapComplete = false;
   public bool nameEntered = false;

   public float PlayerCount;

   public GameObject[] Players;

   private string FinalRecord;

   public Scene level;

   //public GameController gameController;
   public static string playerName;
   //public InputField input_name;

   string currentLevel;
   float oldTime1, oldTime2, oldTime3, oldTime4, oldTime5;
   string oldName1, oldName2, oldName3, oldName4, oldName5;

   void Awake()
   {
       lapTimeText.GetComponent<Text>();
       level = SceneManager.GetActiveScene();

       currentLevel = level.name;

       oldTime1 = PlayerPrefs.GetFloat("BestLapTime_" + currentLevel + "1");
       oldTime2 = PlayerPrefs.GetFloat("BestLapTime_" + currentLevel + "2");
       oldTime3 = PlayerPrefs.GetFloat("BestLapTime_" + currentLevel + "3");
       oldTime4 = PlayerPrefs.GetFloat("BestLapTime_" + currentLevel + "4");
       oldTime5 = PlayerPrefs.GetFloat("BestLapTime_" + currentLevel + "5");

       oldName1 = PlayerPrefs.GetString("PlayerName_" + currentLevel + "1");
       oldName2 = PlayerPrefs.GetString("PlayerName_" + currentLevel + "2");
       oldName3 = PlayerPrefs.GetString("PlayerName_" + currentLevel + "3");
       oldName4 = PlayerPrefs.GetString("PlayerName_" + currentLevel + "4");
       oldName5 = PlayerPrefs.GetString("PlayerName_" + currentLevel + "5");
   }

   void Update()
   {
       if (Input.GetKeyDown(KeyCode.End))
       {
           float x = 180;
           int y = 1;
           for (int i = 1; i <= 5; i++)
           {
               PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + i.ToString(), x);
               PlayerPrefs.SetString("PlayerName_" + currentLevel + i.ToString(), "Player " + y.ToString());
               x = x + 30;
               y = y + 1;
           }
       }
       if (Input.GetKeyDown(KeyCode.Delete))
       {
           PlayerPrefs.DeleteAll();
       }


       for (int i = 0; i < Players.Length; i++)
       {
           if(Players[i].GetComponent<PlayerController>().Finish)
           {
               lapComplete = true;
           }
       }

       if (lapComplete == false)
       {
           lapTime += Time.deltaTime;
           lapTimeString = FormatLapTime(lapTime);
           lapTimeText.text = lapTimeString;
       }
       else
       {
           if (nameEntered == false)
           {
               if (lapTime < oldTime5)
               {
                   //gameController.playerNameMenu.SetActive(true);
                   //playerName = input_name.GetComponent<InputField>().text;
                   playerName = "Name";
//                    gameController.highScoreMenu.SetActive(true);

                   if (lapTime < oldTime4)
                   {
                       if (lapTime < oldTime3)
                       {
                           if (lapTime < oldTime2)
                           {
                               if (lapTime < oldTime1)
                               {
                                   ChangeHighScore1(lapTime, playerName);
                               }
                               else
                               {
                                   ChangeHighScore2(lapTime, playerName);
                               }
                           }
                           else
                           {
                               ChangeHighScore3(lapTime, playerName);
                           }
                       }
                       else
                       {
                           ChangeHighScore4(lapTime, playerName);
                       }
                   }
                   else
                   {
                       ChangeHighScore5(lapTime, playerName);
                   }

                   nameEntered = true;
               }
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

   // Change high score 1 with new score
   // Replace high scores 2-5 with the previous high scores
   void ChangeHighScore1(float newTime, string newName)
   {
       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "1", newTime);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "1", newName);

       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "2", oldTime1);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "2", oldName1);

       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "3", oldTime2);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "3", oldName2);

       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "4", oldTime3);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "4", oldName3);

       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "5", oldTime4);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "5", oldName4);
   }

   // Change high score 2 with new score
   // Replace high scores 3-5 with the previous high scores
   void ChangeHighScore2(float newTime, string newName)
   {
       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "2", newTime);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "2", newName);

       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "3", oldTime2);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "3", oldName2);

       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "4", oldTime3);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "4", oldName3);

       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "5", oldTime4);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "5", oldName4);
   }

   // Change high score 3 with new score
   // Replace high scores 4-5 with the previous high scores
   void ChangeHighScore3(float newTime, string newName)
   {
       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "3", newTime);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "3", newName);

       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "4", oldTime3);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "4", oldName3);

       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "5", oldTime4);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "5", oldName4);
   }

   // Change high score 4 with new score
   // Replace high score 5 with the previous high score
   void ChangeHighScore4(float newTime, string newName)
   {
       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "4", newTime);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "4", newName);

       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "5", oldTime4);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "5", oldName4);
   }

   // Change high score 5 with new score
   void ChangeHighScore5(float newTime, string newName)
   {
       PlayerPrefs.SetFloat("BestLapTime_" + currentLevel + "5", newTime);
       PlayerPrefs.SetString("PlayerName_" + currentLevel + "5", newName);
   }
}
