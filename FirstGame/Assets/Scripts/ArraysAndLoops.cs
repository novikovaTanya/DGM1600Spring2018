using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndLoops : MonoBehaviour {


	public Player[] Players;
	public int[] HighScores;
	public PowerUp[] PowerUps;

	void Start () {
		foreach (var player in Players)
			print(player.playerName + " " + player.score + " " + player.MPs);
		
		foreach (var player in Players)
			if (player.score > 1000)
				print(player.playerName + "'s score is higher than 1000");
	}
}
