using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerMichael : MonoBehaviour {

	//Audio
	/* 
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

	//Player Number
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

	void Start ()
	{
		//referencing the player manager
		GameObject manager = GameObject.Find ("playerManager");
		playerSpawner playerSpawn = manager.GetComponent<playerSpawner> ();
		playNumb = playerSpawn.setPlayerNumber ();
		rb = GetComponent<Rigidbody>();
		ren = GetComponent<Renderer> ();

		audioSource.clip = audioBreakClip;
	}

	private void FixedUpdate()
	{
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

			//move player
			Move ();
		}
		else
		{
			//do nothing
		}
	}

	private void Move()
	{
		//move in direction
		rb.AddForce ((MoveVector * speed));
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
	*/
}
