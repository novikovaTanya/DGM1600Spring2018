using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
	Switch Statement Assignment:

	switch statement is like a set of if statements
		syntax for a switch statement:
			switch(expression) {
				case constant-expression:
					// do work
					// break; (optional)
				
				// more cases
				...

				default:
					// default case
			}
	switch statement can include any number of switch cases
	when break statement is reached, the switch terminates

	Below are few examples of using switch statement:
*/


public class Switch : MonoBehaviour {

	public string UserName;
	public PowerUpBase MyPowerUpBase;

	void OnMouseDown () {
		switch (UserName) {
			case "Password":
				print("Password is correct");
				break;
			case "LevelUp":
				print("You win! Next Level.");
				break;
			default:
				print("Why don't you just tell me what to do?");
				break;
		};


		// switch(MyPowerUpBase) {
		// 	case AmmoPowerUp a:
		// 		print("Ammo Power Up");
		// 		break;
		// 	case HealthPowerUp h:
		// 		print("Health Power Up");
		// 		break;
		// 	default:
		// 		print("No match...");
		// 		break;
		// }
	}
}
