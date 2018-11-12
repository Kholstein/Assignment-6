using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public PlayerController PC;

	public GameObject[] CPlist;

	void Update()
	{
		for(int i = 0; i < CPlist.Length; i++)
        {
            if (Vector3.Distance(PC.transform.position, this.transform.position) < 5)
			{
				//PC.Checkpointpos = CPlist[i].transform.position;
			}
        }
	}

}
