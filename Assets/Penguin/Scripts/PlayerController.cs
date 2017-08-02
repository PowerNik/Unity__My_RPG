using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public GameObject Bomb;
	public float Speed = 0.75f;
	public float JumpForce = 5;

	float maxVelocityXZ = 10f;
	float SpeedRotation = 3f;
	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	public void Moving(Vector3 direction)
	{
		Vector2 velocityXZ = new Vector2(rb.velocity.x + direction.x * Speed, rb.velocity.z + direction.z * Speed);
		if (velocityXZ.magnitude < maxVelocityXZ)
		{
			rb.velocity += direction * Speed;
		}
	}

	public void RotateX(float rotating)
	{
		transform.Rotate(Vector3.up * rotating * SpeedRotation);
	}

	public void Jumping()
	{
		rb.AddForce(rb.transform.up * JumpForce, ForceMode.Impulse);
	}

	public void PutABomb()
	{
		Vector3 bombPosition = transform.position + 2 * (transform.localRotation * Vector3.forward);
		bombPosition.y = 0;
		Instantiate(Bomb, bombPosition, Quaternion.identity);
	}
}
