using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setPlayerCount : MonoBehaviour {
	public int playerCounter;
	public Text playerCountText;
	public void setPlayers () {
		playerSpawner.playerCount = playerCounter;
		playerCountText.text = "Current Players: " + playerCounter.ToString ();
	}
}