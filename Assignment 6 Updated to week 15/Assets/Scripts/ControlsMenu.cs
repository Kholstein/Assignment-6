using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsMenu : MonoBehaviour {

    public GameObject keyboardControls;
    public GameObject xboxOneControls;
    public GameObject pS4Controls;

    public void ShowKeyboardControls()
    {
        keyboardControls.SetActive(true);
        xboxOneControls.SetActive(false);
        pS4Controls.SetActive(false);
    }

    public void ShowXboxOneControls()
    {
        keyboardControls.SetActive(false);
        xboxOneControls.SetActive(true);
        pS4Controls.SetActive(false);
    }

    public void ShowPS4Controls()
    {
        keyboardControls.SetActive(false);
        xboxOneControls.SetActive(false);
        pS4Controls.SetActive(true);
    }
}
