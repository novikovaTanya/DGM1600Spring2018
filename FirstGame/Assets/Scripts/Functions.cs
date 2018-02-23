using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Void Functions:
 *
 *  If the 'void' keyword is used as the return type for the method,
 * 	it means that the method doesn't return a value.
 *
 *
 * Functions with Parameters:
 *
 * 	You can pass different arguments to the methods.
 *	There are few ways to declare method parameters:
 * 		* params
 * 		* ref
 * 		* out
 *
 * 	params:
 * 		allows you to specify a method parameter that takes a variable number of arguments
 * 		only one params keyword is permitted in the method declaration
 * 		no additional parameters are permitted after the params keyword
 * 			method-return-type method-name(params data-type[] agr-name) { ... }
 *
 * 	ref:
 * 		allows you to pass parameter by reference, not by value
 * 		which means that any change to the argument is reflected in the calling method
 * 		you have to explicitly specify the ref keyword in the method definition and the calling method:
 * 			method-return-type method-name(ref data-type agr-name) { ... }
 * 			method-name(ref your-variable); // your-variable has to be initialized before calling the function
 * 	out:
 * 		allows you to pass an argument to a method by reference rather than by value
 * 		out is like the ref keyword, except you don't have to initialize the variable
 * 			before passing it to the method, but the method itself has to assign the value to that variable
 * 			before returning the result
 *
 *
 * Below are few examples for defining void methods and functions with parameters:
 */


public class Functions : MonoBehaviour {

	public void MyMethod()
	{
		print("MyMethod doesn't return anything and doesn't take any parameters");
	}

	public void MyMethod2(int a, int b)
	{
		print("MyMethod2 takes two parameters, but doesn't return anything");
		print("It just prints to console: a + b = " + (a + b));
	}
	
	
	
	void OnMouseDown ()
	{
		print("test");
		MyMethod();
		MyMethod2(2, 3);
	}
}
