using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Move Pattern")]
public class MovePattern : ScriptableObject {
	public Config config;
	private Vector3 direction;

	public InputBase inputX;
	public InputBase inputY;

	private void OnEnable()
	{
		direction = config.intitialPosition;	
	}

	public void Move(CharacterController controller, Transform transform) {
		if (controller.isGrounded) {
			direction.x = inputX.SetInput() * config.speed;
			direction.z = inputY.SetInput() * config.speed;
			direction.y = (Input.GetButton("Jump")) ? config.jumpSpeed : 0;

			direction = transform.TransformDirection(direction);
        }
		direction.y -= config.gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime);
	}
}
