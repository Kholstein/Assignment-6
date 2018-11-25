using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoresManager : MonoBehaviour {

    public GameObject highScores;
    public GameObject Menu;

    public void ShowHighScores()
    {
        highScores.SetActive(true);
        Menu.SetActive(false);
    }

    public void HideHighScores()
    {
        highScores.SetActive(false);
        Menu.SetActive(true);
    }
}
