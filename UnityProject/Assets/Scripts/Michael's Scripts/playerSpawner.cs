using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerSpawner : MonoBehaviour {
	public GameObject player;
	public Transform[] spawnPoints;
	public Camera cam;
	private int playerNumber;
	private int countPlayer = 0;
	private int countPlayerNumber = 1;
	private int camNumber = 0;
	private int countCamNumber = 1;
	private int setCamNumCount= 0;
	public int playerCount = 4;
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;


	//public int setPlayerNumber;
	// Use this for initialization

	void Start () {
		spawnPlayers ();
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton9))
		{
			if (GameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
	}


	void spawnPlayers ()
	{
		
		for (int i = 1; i <= playerCount; i++) {
			GameObject spawnedChild = Instantiate (player, spawnPoints [countPlayer].position, spawnPoints [countPlayer].rotation);
			Camera childCam = spawnedChild.GetComponentInChildren<Camera> ();
			countPlayer++;
			if (i == 1) {
				childCam.gameObject.tag = "camera1";
				childCam.rect = new Rect (0.0f, 0.5f, 0.5f, 0.5f);
			}
			else if (i == 2) {
				childCam.gameObject.tag = "camera2";
				childCam.rect = new Rect (0.5f, 0.5f, 0.5f, 0.5f);
			}
			else if (i == 3) {
				childCam.gameObject.tag = "camera3";
				childCam.rect = new Rect (0.0f, 0.0f, 0.5f, 0.5f);
			}
			else if (i == 4) {
				childCam.gameObject.tag = "camera4";
				childCam.rect = new Rect (0.5f, 0.0f, 0.5f, 0.5f);
			}
		}
	}

	public int setPlayerNumber()
	{
		playerNumber = countPlayerNumber++;
		return playerNumber;
	}

	public int setCamNumber()
	{
		camNumber = countCamNumber++;
		return camNumber;
	}

	public int setCamRectNumber()
	{
		setCamNumCount++;
		return setCamNumCount;
	}
	public void Resume ()
	{
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	public void Pause ()
	{
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

//	//SceneManager.LoadScene("LevelSelect");
//	public void MenuReturn ()
//	{
//		Debug.Log ("Retunring to Menu...");
//		SceneManager.LoadScene("MainMenu");
//
//	}
}
