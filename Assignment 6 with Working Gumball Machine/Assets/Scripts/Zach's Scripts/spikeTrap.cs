/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeTrap : MonoBehaviour
{
    public float pushBackForce;
    public AudioClip SoundToPlay;
    AudioSource audio;

    [SerializeField] public player;


        private void OnTriggerEnter(Collider player)
    {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(SoundToPlay); // Play an audio sound once.

        Vector3 dir = player.contacts[0].point - transform.position;
        dir = -dir.normalized;
        GetComponent<Rigidbody>().AddForce(dir * pushBackForce);
    }
}
*/
