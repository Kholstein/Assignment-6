using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupInstantiate : MonoBehaviour

{
    public GameObject powerupPrefab = null;

    void Start()
    {
        Instantiate(powerupPrefab, transform.position, Quaternion.identity);
    }
}