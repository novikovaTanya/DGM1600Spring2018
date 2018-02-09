using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour {

	public int A = 1;
	public int B = 3;
	public string Password;

	// Operators assignment:

	/*
		There are a lot of operators in C#, like
		.(access operator), ++(increment operator), multiplicative(*,/,%), additive(+,-),
		logical(&&(and), ||(or), !(not), ^(xor)), equality(==, !=),
		assignment(=, +=, *+, ...) and other operators.
		Below are few examples using operators:
	 */
	
	
	/*
	 * Variables and Math Operators:
	 *
	 * C# provides few mathematical operators:
	 * 		addition(+)
	 * 		substruction(-)
	 * 		multiplication(*)
	 * 		division(/)
	 * 		modulus(%)
	 *
	 * These operators work as they would work in simple math.
	 * An exeption is the division:
	 * 		- when you divide two integers, the result will be without fractional part
	 * 		- when at lease one of dividers is float or double, the result will keep the fractional part and returns a decimal value
	 *
	 * Modulus operator % calculates the reminder from an integer division
	 *
	 *
	 * Variable is something that can store some value. You can access your variable by its name.
	 * You can change the initial value of you variable.
	 *
	 * Syntax:
	 * 		[modifier] type name
	 *
	 * You can define your variable during the declaration or you can do it separately
	 *		[modifier] type name = value;
	 * or
	 * 		[modifier] type name;
	 * 		name = value;
	 *
	 * You can also do not specify the type of the variable, using keyword 'var'. Then the type will be defined implicitly
	 * 		var name = value;
	 * 
	 * Bellow are few examples:
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

		
		
		// Dividing integers
		var i = 31 / 5; // returns 6
		// Dividing floats
		var d = 31.0 / 5; // returns 6.2
		// Modulus
		var m = 31 % 5; // returns 1

		print(i);
		print(d);
		print(m);


		int x = 10;
		int y = 3;
		double yy = 3.0;
		int z;
		double zz;
		
		z = x + y;
		print("x + y = " + z);
		
		z = x - y;
		print("x - y = " + z);
		
		z = x * y;
		print("x * y = " + z);
		
		z = x / y;
		print("x / y = " + z);
		zz = x / yy;
		print("x / yy = " + zz);
		
		z = x % y;
		print("x % y = " + z);

	}
}
