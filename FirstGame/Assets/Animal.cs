using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
	public bool Key = false;
	public bool Hungry = false;

	void OnMouseDown()
	{

		// If Statements Assignment:

		/*
			If-statement should contain an 'if' keyword, followed by the condition and the body of the if-statement.
			If the condition is true, what's inside the if-statement will be executed.
		 */

		// "Open door." will be executed if the Key variable is true
		// if (Key == true) is the same as if (Key)

		if(Key) {
			print("Open door.");
		}

		// Here are few more examples of if-statements
		if(Hungry) {
			print("Feed me, human!");
		}

		if(2 + 3 == 566) {
			print("This line won't print");
		}

		if (!Hungry) {
			print("My animal is not hungry!");
		}

		if (Hungry == false) {
			print("My animal is not hungry!!!");
		}

		if(false) {
			print("Will never get here.");
		}
	}
}
