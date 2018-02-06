using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour {

	public int A = 1;
	public int B = 3;
	public string Password;

	// Operators assignment:

	/*
		There are a lot of operators in C#, like ,
		.(access operator), ++(increment operator), multiplicative(*,/,%), additive(+,-),
		logical(&&(and), ||(or), !(not), ^(xor)), equality(==, !=),
		assignment(=, +=, *+, ...) and other operators.
		Below are few examples using operators:
	 */

	void Start () {
		// example of AND operator
		if(A == B && Password == "TEST")
		{
			print("The password is correct, and A is equal B");
		}

		// example of OR operator
		if(A > B || A < B)
		{
			print("A is not equal B");
		}

		// example of NOT EQUAL operator
		if(A != B)
		{
			print("A is not equal B");
		}

		// Add value 10 to A
		A += 10;
		// now A is 1 + 10 = 11

		// Multiply B by 2
		B *=2;
		// now B is 3 * 2 = 6

	}
}
