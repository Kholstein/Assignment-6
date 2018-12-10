using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteGumDrop : MonoBehaviour {

	public GameObject Gumball;
	public Material[] matlist;

	private Vector3 SpawnPos;
	public float timer;
	private bool spawned = false;

	private GameObject GumSpawn;
	void Start () 
	{
		SpawnPos = transform.position;
		this.gameObject.GetComponent<Renderer>().material = matlist[Random.Range(0,4)];
		timer = 0;
	}
	
	
	void Update () 
	{
		timer += Time.deltaTime;
		if (timer > 3 & !spawned)
		{
			GumSpawn = Instantiate(Gumball, SpawnPos, transform.rotation);
			spawned = true;
		}
	}
}
