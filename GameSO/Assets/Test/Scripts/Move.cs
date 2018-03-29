using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	private CharacterController controller;
	public MovePattern pattern;

	private void Start() {
		controller = GetComponent<CharacterController>();
	}

    void Update() {
        pattern.Move(controller, transform);
    }
}
