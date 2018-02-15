using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForLoopsAndLists : MonoBehaviour {

	/*
		For-loops and Lists Assignment:
		
		For loop:
			for loops allow us to run the piece of core multiple times
			you can specify how many times you want to run the loop
			syntax
				for (initializer; condition; iterator)  { ... }
			all expressions that are in for loop are optionals, so you can define an infinite loop like that:
				for( ; ; ) { ... } // or you can use while(true) { ... } to do the same action
	
		Lists:
			List is a class that represents strongly typed list of objects
			objects in list can be accessed by its index
			you can also add/delete elements to the list
			there are a lot of standart methods for the class List, like Count, Sort, Insert, Add, Contains, etc.
			syntax:
				List<type> name;


	Below are few examples of for loops and List:
	*/

	public List<string> Names;
	public Incredibles incredibles;
	public string AddMember;
	public int index = 0;
	public Text NewMember;

	void Start () {
		
		Names.Add("Name5");

		for (int i = 0; i < 5; i++)
			Names.Add("Name #" + i);

		for (int i = 3; i < 5; i++)
			for (int j = 0; j > -3; j--)
				print("i * j = " + i + " * " + j + " = " + (i * j));

		
		while(index < 20)
		{
			print("index is " + index);
			index++;
		}

		Names.ForEach(print);

		incredibles.FamilyList.Add(AddMember);
		incredibles.FamilyList.ForEach(print);

		if(incredibles.FamilyList.Contains("Tanya"))
			print("Tetiana is now a member of the incredibles family");

		Names.Clear();
	}

	void OnMouseDown()
	{
		incredibles.FamilyList.Add(NewMember.text);
	}
}
