﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Substract : Calculation {
	public override float Action(float a, float b) {
		return a - b;
	}
}
