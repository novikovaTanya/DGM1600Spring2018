using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
	public bool Key = false;
	public bool Hungry = false;

	void OnMouseDown()
	{
		if(Key) {
			print("Open door.");
		}

		if(Hungry) {
			print("Feed me, human!");
		}
	}
}
