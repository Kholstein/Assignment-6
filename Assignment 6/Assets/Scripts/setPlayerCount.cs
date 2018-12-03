using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPlayerCount : MonoBehaviour {
	public int playerCounter;
	public void setPlayers () {
		playerSpawner.playerCount = playerCounter;
	}
}