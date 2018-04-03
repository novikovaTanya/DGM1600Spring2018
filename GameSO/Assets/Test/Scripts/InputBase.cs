using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Input")]
public class InputBase : ScriptableObject {
	public string direction;
	public float SetInput() {
		return Input.GetAxis(direction);
	}
}
