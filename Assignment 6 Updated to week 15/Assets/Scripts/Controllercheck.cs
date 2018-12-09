using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllercheck : MonoBehaviour {

    public GameObject XboxControls;
    public GameObject KeyboardControls;
    public GameObject PlaystationControls;
    private int Xbox_One_Controller = 0;
    private int PS4_Controller = 0;

    void OnEnable()
    {
        string[] names = Input.GetJoystickNames();
        for (int x = 0; x < names.Length; x++)
        {
            Debug.Log(names[x].Length);
            if (names[x].Length == 33)
            {
                Debug.Log("Xbox");
                Xbox_One_Controller = 1;
                PS4_Controller = 0;
            }
            else if (names[x].Length == 19)
            {
                Debug.Log("PS4");
                Xbox_One_Controller = 0;
                PS4_Controller = 1;
            }
            else
            {
                Debug.Log("Keyboard");
                Xbox_One_Controller = 0;
                PS4_Controller = 0;
            }
        }

        if (Xbox_One_Controller == 1)
        {
            XboxControls.SetActive(true);
            KeyboardControls.SetActive(false);
            PlaystationControls.SetActive(false);
        }
        else if (PS4_Controller == 1)
        {
            XboxControls.SetActive(false);
            KeyboardControls.SetActive(false);
            PlaystationControls.SetActive(true);
        }
        else
        {
            PlaystationControls.SetActive(false);
            XboxControls.SetActive(false);
            KeyboardControls.SetActive(true);
        }
    }
}
