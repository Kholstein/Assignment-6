using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerName : MonoBehaviour {

    public string playerName;
    public InputField m_name;
    public GameObject playerNameMenu;
    public LapTimeManager lapTimeManager;

    void Awake()
    {
        playerNameMenu.GetComponent<GameObject>();
    }

    void Update()
    {
        playerName = m_name.GetComponent<InputField>().text;
    }

    public void OnClick()
    {
        lapTimeManager.nameEntered = true;
        playerNameMenu.SetActive(false);
    }
}
