using System.Collections;
using UnityEngine;

public class lavaTrapScript: MonoBehaviour
{
    public float BlinkForThisManySeconds;
    public bool Waited;
    public AudioClip SoundToPlay;
    AudioSource audio;

    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider player) // When a player collides...
    {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(SoundToPlay); // Play an audio sound once.

        StartCoroutine(BlinkingDamage()); // Wait for X seconds and blink.

        if (Waited == true) // After waiting for X seconds...
        {
            //player.transform.position = respawnPoint.transform.position; // Respawn the player.
            Debug.Log("Wait completed!");
        }
        else
        {
            Debug.Log("Wait not completed!");
        }


    }
    IEnumerator BlinkingDamage()
    {
        yield return new WaitForSeconds(BlinkForThisManySeconds); // Wait for X seconds.
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////ERROR - There is no 'MeshRenderer' attached to the "playerManager" game object, but a script is trying to access it.//////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*for(int BlinkCount = 0; BlinkCount < 5; BlinkCount++) //Make the player 'blink' for 5 seconds. 
        {
            Debug.Log("Counting!");
            player.GetComponent<MeshRenderer>().enabled = true;
            player.GetComponent<MeshRenderer>().enabled = false;
    }*/

        Waited = true; // Turn bool value to true.

    }
}