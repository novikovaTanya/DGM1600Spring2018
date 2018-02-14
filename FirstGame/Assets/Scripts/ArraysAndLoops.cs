using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Arrays and Loops Assignment:


An array is a collection of same type elements.
	- declaration of an array
		type[] name;
	- initialization of an array
		* using 'new' keyword, you can create a new instance of the array
		* type[] name = {values...};
		* int[] name = new int[4] {1, 2, 3, 4}; 
	- access an element of an array
		arrayName[index]


Foreach statement is used to iterate through an array
	- syntax
		foreach (var name in arrayName) { ... }

Below are few examples of using arrays and foreach loops
*/

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

		print("The fisrt player in array is " + Players[0].playerName);

		foreach (var powerUp in PowerUps)
		{
			print(powerUp.PowerLevel);
		}
	}
}
