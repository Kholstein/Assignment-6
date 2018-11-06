using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

    public float speed;

    public Rigidbody rb;
    public GameObject[] CPlist;

    private Vector3 Checkpointpos;

    private bool Finish;

    void Start ()
    {
        Checkpointpos = transform.position;
        Finish = false;
    }

    void Update ()
    {
        Movement();
        PlayerHealth();
        if(Finish)
        {
            Debug.Log("Finished Race");
        }
    }

    void Movement()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
        
    }

    void PlayerHealth()
    {
        if(transform.position.y <= -10)
        {
            transform.position = Checkpointpos;
        }

        for(int i = 0; i < CPlist.Length; i++)
        {
            if (Vector3.Distance(transform.position, CPlist[i].transform.position) < 5)
            {
                Checkpointpos = CPlist[i].transform.position;
            }
            if (Vector3.Distance(transform.position, CPlist[CPlist.Length-1].transform.position) < 5)
            {
                Finish = true;
            }
        }
    }
}
