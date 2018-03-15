using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Calculation : ScriptableObject {
	public float Calculate(string a, string b) {
		try {
			return Action(float.Parse (a), float.Parse (b));
		}
		catch (InvalidCastException e) {
			throw;
		}
	}

	public abstract float Action (float a, float b);
}
