using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerUpPickUp : MonoBehaviour
{
    public float duration = 4f;
    public GameObject player; //A player
    public GameObject pickUpEffect; // What particle effect happens when object is pickedup.
    private AudioSource soundOrigin; // What the sound is coming from.
    public AudioClip pickUpSound; // What sound plays when the powerup has been picked up.

    public Text UI;



    void Start()
    {
        player = GameObject.Find("")
        soundOrigin = GetComponent<AudioSource> ();
    }
    void OnTriggerEnter(Collider other) // When a plyer walks into the powerup...
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine( pickUp()); // ...call the method used to pickup the powerup
            // other.gameObject.SetActive(false);
        }
    }

    IEnumerator pickUp() // This method will give the player a random powerup and then deactivate itself.
    {
        //Instantiate(pickUpEffect, transform.position, transform.rotation); // Causes a specific particle effect to show when powerup is picked up

        
        soundOrigin.PlayOneShot(pickUpSound); // Play sound once

        // List<"i"> = powerUpsList[Random.range(0, powerUpsList.Count)] // Select a random element from the list of powerups...


        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration); // Wait for this long...

        UI.text = "powerup expire";

        gameObject.SetActive(false); // ... until deactivating the powerup

    }
}