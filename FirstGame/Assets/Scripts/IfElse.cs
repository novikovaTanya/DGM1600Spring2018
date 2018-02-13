using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour {

	public bool Key;
	public int MyValue = 2;
	public string str = "Hello world!";

	/*
		Else Clause Assignment:

		Else clause provides opportunity to execute the code in case the condition of if-clause isn't met
		To use else clause, you have to write 'else' key word and the code insides of curly brackets.
	 */

	// Use this for initialization
	void Start () {

		// Here are few examples how to use else clause:

		if(Key) {
			print("I have the key");
		} else {
			print("I don't have the key");
		}


		if(MyValue > 4) {
			print("My value is greater than 4");
		} else if (MyValue == 3) {
			print("My Value is 3");
		} else {
			print("My value is less than 4 and not 3");
		}


		// you can omit the curly brackets if the code inside the clause is one line 
		if(str == "Hello!")
			print("My string is 'Hello!'");
		else
			print("My string is not 'Hello!'; it is '" + str + "'");

		// or you can use one line notation for if-else clause:
		// 		condition ? true_expression : false_expression
		str = (MyValue > 4) ? "My value is greater than 4" : "My value isn't greater than 4";

	}

}
