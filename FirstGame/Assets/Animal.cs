using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Assignment - Conventions and syntax

`public` is an identifier that allows us to access the class/method/variable publicly, without any restictions
`class` is keyword for creating the class
after the `class` keyword the name of the class goes
classes can follow the inheritance (have a father classes), which in C# is specified by `:`
everything what's inside curly brakets identify the class
class can have methods and variables

by defining a function you have to specify the returning type of that function
type `void` means that the function doesn't return anything
you can pass arguments to the function

to call the function you have to write the function name and the brakets, passing the parameters(if any)

semicolon goes after each piece of code */

/* Assignment - Variables
Variable is something that can store data. Variables can change.
They can have different types, like int (integer), string (an array of characters), float, bool, etc.
You can define/create your own type.

To declare a variable you have to specify its type and identifier
*/ 



public class Animal : MonoBehaviour {

	// string, int, bool, float are data types
	// Name, FoodCourt, Hungry, MyFloat, HasFur are variables' identifiers
	public string Name;
	public int FoodCount;
	public bool Hungry;
	public float MyFloat;
	public bool HasFur;

	// Hey there!
	// This is a new comment
	// Use this for initialization
	void Start () {
		print("An aminal is eating.");
		print("I love my animal.");
	}
	
	void OnMouseDown()
	{
		// You can access the variable by its identifier
		print("I have a " + Name);
		print("It has this amount of food: " + FoodCount);
		print("Is hungry? - " + Hungry);
		print("Does it have fur? - " + HasFur);

		// You can change the variable
		Hungry = false;
		FoodCount++;
		Name += " :)";
	}

	// Update is called once per frame
	void Update () {
		
	}	
}
