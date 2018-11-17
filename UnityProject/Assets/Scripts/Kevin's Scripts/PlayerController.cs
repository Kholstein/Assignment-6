//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.UI;
//public class PlayerController : MonoBehaviour {

//    public float speed;
//    public Rigidbody rb;
//    public GameObject[] CPlist;
//    public int playerNumber = 0;

//    private Vector3 Checkpointpos;
//    [HideInInspector]
//    public bool Finish;

//    //public Text DebugText;

//    public LapTimeManager LTM;

//    void Awake () 
//	{
//        LTM.PlayerCount += 1;
//        //DebugText.text = "Race Begin";
//        Checkpointpos = transform.position;
//        Finish = false;
//	}

//    void Update ()
//    {
//        Movement();
//        PlayerHealth();
//        if(Finish)
//        {
//            //DebugText.text = "Race Finished";
//        }
//    }

//    void Movement()
//    {
//        float moveHorizontal = Input.GetAxis ("Horizontal");
//        float moveVertical = Input.GetAxis ("Vertical");

//        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

//        rb.AddForce (movement * speed);
//    }

//    void PlayerHealth()
//    {
//        if(transform.position.y <= -10)
//        {
//            transform.position = Checkpointpos;
//        }

//        for(int i = 0; i < CPlist.Length; i++)
//        {
//            if (Vector3.Distance(transform.position, CPlist[i].transform.position) < 5)
//            {
//                Checkpointpos = CPlist[i].transform.position;
//            }
//            if (Vector3.Distance(transform.position, CPlist[CPlist.Length-1].transform.position) < 5)
//            {
//                Finish = true;
//            }
//        }
//    }
//}
