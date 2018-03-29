using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Config : ScriptableObject {
	public float speed;
	public float jumpSpeed;
	public float gravity;
	public Vector3 intitialPosition = Vector3.zero;
}
