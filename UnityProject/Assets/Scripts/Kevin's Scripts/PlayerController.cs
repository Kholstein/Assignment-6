using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

    public float speed;

    public Rigidbody rb;

    private Vector3 Checkpointpos;

    void Start ()
    {
        Checkpointpos = transform.position;
    }

    void Update ()
    {
        Movement();
        PlayerHealth();
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
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Checkpoint")
        {
            Physics.IgnoreCollision(other.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
            Checkpointpos = other.transform.position;
        }
    }
}
