using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
	Scope and Access Modifiers Assignment
	
	Slope:
		The scope of a variable is the area in code which the variable can be used in.
		Code blocks are usually what defines variable's scope - { ... }
		Another local variable with the same name cannot be declared in the current block or any nested blocks

	Access Modifiers:
		There are few access modifiers in C#:
			public:
				fully accessible
			internal:
				accessible only within the containing assembly or friend assemblies (the default one for non-nested types)
			private:
				accessible only within the containing type (the default one for members of a class ot struct)
			protected:
				accessible only within the containing type or subclasses
			protected internal:
				combination of protected and internal accessibility

	Below are few examples of using access modifiers
*/

public class A {
	public string publicName = "I am a public variable in class A";
	private string privateMsg = "I am accessible only inside the class A";
	protected string protectedVar = "I came from class A or its children (subclasses)";

	public string GetPrivateVar() {
		return privateMsg;
	}
}

public class B : A {
	// scope of the publicName variable is inside B class
	public string publicName = "I am a public variable in class B";

	public string getProtectedVar() {
		return protectedVar;
	}
}

public class ScopeAndAccessModifiers : MonoBehaviour {

	public int a = 0;

	void Start() {
		// local variables
		int a = 7;
		int b = 4;
		int x = 100;

		if (a > b) {
			// won't work because the x is already defined in the parent scope
			// 		int x = a + b;
			
			print("x inside if statement is equal to " + x);
		}
	}

	void OnMouseDown() {
		A myA = new A();
		B myB = new B();

		print (myA.publicName);
		print (myB.publicName);

		// this is not going to work, because privateMsg is a private variable
		// 		print (myA.privateMsg);

		// you cannot access the private variable of the class,
		// but the class may have getter method which returns the value of that variable
		print(myA.GetPrivateVar());

		// it's not going to work, because protected variable for subclasses can be used only inside the class or its subclasses
		// 		print (myB.protectedVar);

		// but the class may have getter method which returns the value of that variable
		print(myB.getProtectedVar());
	}

}
