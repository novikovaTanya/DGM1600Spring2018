using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Assignment - Conventions and syntax
// 
// `public` is an identifier that allows us to access the class/method/variable publicly, without any restictions
// `class` is keyword for creating the class
// after the `class` keyword the name of the class goes
// classes can follow the inheritance (have a father classes), which in C# is specified by `:`
// everything what's inside curly brakets identify the class
// class can have methods and variables

// by defining a function you have to specify the returning type of that function
// type `void` means that the function doesn't return anything
// you can pass arguments to the function

// to call the function you have to write the function name and the brakets, passing the parameters(if any)

// semicolon goes after each piece of code

public class Animal : MonoBehaviour {

	// Hey there!
	// This is a new comment
	// Use this for initialization
	void Start () {
		print("An aminal is eating.");
		print("I love my animal.");
	}
	
	void OnMouseDown()
	{
		print("Meow.");
	}

	// Update is called once per frame
	void Update () {
		
	}	
}
