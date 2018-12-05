using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
	public static int playerCount = 4;
	public GameObject[] PlayerCount;
	//pause script variables
	//public static bool GameIsPaused = false;
	//public GameObject pauseMenuUI;
	public GameObject exitCanvas;
	public float Playersfinish;
	[HideInInspector]
	public float timer;
	public float controllerStartRotation;

	public animateScene AC;

	//Specific Players Pause
	public GameObject pauseMenuUI1;
	public GameObject pauseMenuUI2;
	public GameObject pauseMenuUI3;
	public GameObject pauseMenuUI4;
	public bool paused1 = false;
	public bool paused2 = false;
	public bool paused3 = false;
	public bool paused4 = false;
	public bool buttonOnScreen = false;


	// Canvas for the player for name entered
	public LapTimeManager[] playerCanvas;

	//public int setPlayerNumber;
	// Use this for initialization
	void Start () {
		spawnPlayers ();
		PlayerCount = GameObject.FindGameObjectsWithTag("Player");
		Playersfinish = PlayerCount.Length;
	}

	void Update ()
	{
		if(Playersfinish == 0)
		{
			MenuReturn(5);
		}
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick 1 button 7") || Input.GetKeyDown("joystick 1 button 9"))
		{
			if (paused1) {
				paused1 = false;
			} else {
				paused1 = true;
			}
		}
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick 2 button 7"))
		{
			if (paused2) {
				paused2 = false;
			} else {
				paused2 = true;
			}
		}
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick 3 button 7"))
		{
			if (paused3) {
				paused3 = false;
			} else {
				paused3 = true;
			}
		}
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("joystick 4 button 7"))
		{
			if (paused4) {
				paused4 = false;
			} else {
				paused4 = true;
			}
		}

		if (paused1 || paused2 || paused3 || paused4) 
		{
			Pause ();
		}
		else
		{
			Resume();
		}
	}

	void spawnPlayers ()
	{
		CameraController.editCameraRotation = controllerStartRotation;

		for (int i = 1; i <= playerCount; i++) {
			GameObject spawnedChild = Instantiate (player, spawnPoints [countPlayer].position, spawnPoints [countPlayer].rotation);
			Camera childCam = spawnedChild.GetComponentInChildren<Camera> ();
			countPlayer++;
			if (i == 1) {
				//childCam.gameObject.tag = "camera1";
				childCam.rect = new Rect (0.0f, 0.5f, 0.5f, 0.5f);
			}
			else if (i == 2) {
				//childCam.gameObject.tag = "camera2";
				childCam.rect = new Rect (0.5f, 0.5f, 0.5f, 0.5f);
			}
			else if (i == 3) {
				//childCam.gameObject.tag = "camera3";
				childCam.rect = new Rect (0.0f, 0.0f, 0.5f, 0.5f);
			}
			else if (i == 4) {
				//childCam.gameObject.tag = "camera4";
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
		if (buttonOnScreen) {
			exitCanvas.gameObject.SetActive (false);
			buttonOnScreen = false;
		}
		pauseMenuUI1.SetActive (false);
		pauseMenuUI2.SetActive (false);
		pauseMenuUI3.SetActive (false);
		pauseMenuUI4.SetActive (false);
		Time.timeScale = 1f;
		//GameIsPaused = false;
	}

	public void Pause ()
	{
		if (Input.GetKeyDown(KeyCode.Backspace)) {
				SceneManager.LoadScene ("MainMenu");
		}
		if (!buttonOnScreen) {
			exitCanvas.gameObject.SetActive (true);
			buttonOnScreen = true;
		}
		if (paused1) {
			pauseMenuUI1.SetActive (true);
		} else if (!paused1) {
			pauseMenuUI1.SetActive (false);
		}
		if (paused2) {		
			pauseMenuUI2.SetActive (true);
		} else if (!paused2) {
			pauseMenuUI2.SetActive (false);
		}
		if (paused3) {
			pauseMenuUI3.SetActive (true);
		} else if (!paused3) {
			pauseMenuUI3.SetActive (false);
		}
		if (paused4) {
			pauseMenuUI4.SetActive (true);
		} else if (!paused4) {
			pauseMenuUI4.SetActive (false);
		}
		Time.timeScale = 0f;
	}

	public void MenuReturn(float timermax)
	{
		// check to see if each player with a new high score has entered their name
		int nextScene = 0;
		for (int i = 1; i <= playerCount; i++)
		{
			if (playerCanvas[i - 1].nameEntered == true)
			{
				nextScene++;
			}
		}

		// go to next scene if all players have entered their name for a new high score
		if (nextScene == 4)
		{
			Debug.Log("Victory screen then returning to Menu...");
			timer += Time.deltaTime;
			AC.Animation();
			if (timer > timermax)
			{
				SceneManager.LoadScene("Victory");
			}
		}
	}
}
