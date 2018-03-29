using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public Config config;
    private Vector3 moveDirection;
	private CharacterController controller;

	private void Start() {
		controller = GetComponent<CharacterController>();
		moveDirection = config.intitialPosition;
		controller.Move(moveDirection * Time.deltaTime);
	}

    void Update() {
        if (controller.isGrounded) {
			moveDirection.x = Input.GetAxis("Horizontal") * config.speed;
			moveDirection.z = Input.GetAxis("Vertical") * config.speed;
			moveDirection.y = (Input.GetButton("Jump")) ? config.jumpSpeed : 0;
        }
		moveDirection.y -= config.gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
