using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//Audio
	public AudioSource audioSource;
	// breaking clip
	public AudioClip audioBreakClip;
	//Rubble hitting the Ground clip
	public AudioClip audioRumbleClip;

	//Whether or not the Player has Failed or Won
	public int WinFail = 0;
	//-1 Fail
	//0 Null
	//1 Win

	//delay for speed boost from drift
	public int driftDelay = 0;

	public int driftBoost = 700;

	//variable to divide the speed of the ball
	public int driftSpeed = 1;

	//What lap is the play on
	public int currentLap = 0;

	//Whether or not the player can be Moved
	public int CurrentState = 0;
	//0 cutscene
	//1 playable
	//2 Un-moveable

	//Power up Controler
	public int powerUp = 0;
	//0 None
	//1 Spiked ball
	//2 BearBoost

	//player number
	public int playNumb = 0;

	//Destruction Model
	public GameObject shatterdVersion;

	//movement vector
	public Vector3 MoveVector{set;get;}
	//movement speed
	public float speed;

	//Rigidbody
	private Rigidbody rb;
	//mesh renderer
	private Renderer ren;

	//cameras' Transform
	private Transform camTransform;

	//Checkpoints
	public GameObject[] CPlist;

	private Vector3 Checkpointpos;
	[HideInInspector]

	//Finsih the game
	//public bool Finish;

	//detect race finish
	public bool finishRace = false;
	public int finishCount = 1;
	public static int finishNumber;

	void Awake()
	{
		CPlist = GameObject.FindGameObjectsWithTag ("Checkpoint");
	}
	void Start ()
	{
		//referencing the player manager
		GameObject manager = GameObject.Find ("playerManager");
		playerSpawner playerSpawn = manager.GetComponent<playerSpawner> ();
		playNumb = playerSpawn.setPlayerNumber ();

		//get componets
		rb = GetComponent<Rigidbody>();
		ren = GetComponent<Renderer> ();

		audioSource.clip = audioBreakClip;
	}

	void Update ()
	{
		PlayerHealth();
	}

	private void FixedUpdate()
	{
		if (finishRace) {
			CurrentState = 0;
			//Invoke ("setNextScene", 5);
			//this.gameObject.SetActive (false);
			//Camera playerCam = GetComponentInChildren<Camera> ();
		}
		if (finishNumber == 4) {
			Invoke ("setNextScene", 5);
			//setNextScene ();
		}

		if (driftDelay >= 1) {
			if (driftDelay > 70) {
				driftDelay = 0;
			} else {
				driftDelay += 1;
			}
		}

		if (CurrentState == 0) {
			rb.drag = Mathf.Infinity;
			rb.angularDrag = Mathf.Infinity;
		}
		else if (CurrentState == 1)
		{
				//original input
				MoveVector = PoolInput ();

				//rotate the move vector
				MoveVector = RotateWithView ();
				//simple drift mechanic
				//currentCam = this.gameObject.GetComponentInChildren<Camera>();
				//currentCamTransform = currentCam.gameObject.transform.rotation.eulerAngles;
			if (playNumb == 1)
			{
				if (Input.GetAxis ("P1_Drift") > 0)
				{
					if (driftDelay < 1) {
						speed = driftBoost;
						driftDelay = 1;
						rb.AddForce (-MoveVector * 300);
					}
				} else {
					//move player
					Move ();
					speed = 10f;
				}
			}
			if (playNumb == 2)
			{
				if (Input.GetAxis ("P2_Drift") > 0)
				{
					if (driftDelay < 1) {
						speed = driftBoost;
						driftDelay = 1;
						rb.AddForce (-MoveVector * 300);
					}
				} else {
					//move player
					Move ();
					speed = 10f;
				}
			}
			if (playNumb == 3)
			{
				if (Input.GetAxis ("P3_Drift") > 0)
				{
					if (driftDelay < 1) {
						speed = driftBoost;
						driftDelay = 1;
						rb.AddForce (-MoveVector * 300);
					}
				} else {
					//move player
					Move ();
					speed = 10f;
				}
			}
			if (playNumb == 4)
			{
				if (Input.GetAxis ("P4_Drift") > 0)
				{
					if (driftDelay < 1) {
						speed = driftBoost;
						driftDelay = 1;
						rb.AddForce (-MoveVector * 300);
					}
				} else {
					//move player
					Move ();
					speed = 10f;
				}
			}
		}
		else
		{
			//do nothing
		}

		//if(Finish)
		{
			// DebugText.text = "Race Finished";
		}
	}

	private void Move()
	{
		//move in direction
		rb.AddForce (MoveVector * speed);
	}

	private Vector3 PoolInput()
	{

			Vector3 dir = Vector3.zero;

			//dir.x = Input.GetAxis ("Horizontal");
		if (playNumb == 1)
		{
			dir.y = Input.GetAxis ("P1_Vertical");
		}
		else if (playNumb == 2)
		{
			dir.y = Input.GetAxis ("P2_Vertical");

		}
		else if (playNumb == 3)
		{
			dir.y = Input.GetAxis ("P3_Vertical");

		}
		else if (playNumb == 4)
		{
			dir.y = Input.GetAxis ("P4_Vertical");
		}

		if (dir.magnitude > 1)
			dir.Normalize ();

		return dir;

	}

	private Vector3 RotateWithView()
	{
		if (camTransform != null)
		{
			Vector3 dir = camTransform.TransformDirection (MoveVector);
			dir.Set (dir.x, 0, dir.z);
			return dir.normalized * MoveVector.magnitude;
		}
		else
		{
			camTransform = this.gameObject.transform.GetChild (0);
			return MoveVector;
		}
	}

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Finish")) {
			finishRace = true;
			finishNumber = finishCount;
			finishCount++;
		}
	}

	void OnCollisionEnter (Collision col)
	{
		//if not already in a fail state
		if (col.gameObject.name == "FailTrigger")
		{
			if (CurrentState == 1 && WinFail != -1) {
				//create rubble pile
				Instantiate (shatterdVersion, transform.position, transform.rotation);
				//un-render full marble
				ren.enabled = false;
				//set the condition to failure
				WinFail--;
				//no longer allow player to move
				CurrentState = 2;
				rb.drag = Mathf.Infinity;
				rb.angularDrag = Mathf.Infinity;

				//play sound
				audioSource.Play ();

			}
			else
			{
				//do nothing
			}
		}
	}

	void PlayerHealth()
	{
		if (transform.position.y <= -10) {
			transform.position = Checkpointpos;
		}

		for (int i = 0; i < CPlist.Length; i++) {
			if (Vector3.Distance (transform.position, CPlist [i].transform.position) < 5) {
				Checkpointpos = CPlist [i].transform.position;
			}
			if (Vector3.Distance (transform.position, CPlist [CPlist.Length - 1].transform.position) < 5) {
				//Finish = true;
			}
		}
	}
}
