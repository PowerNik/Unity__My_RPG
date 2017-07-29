using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public GameObject Bomb;
	public float Speed = 10f;
	public float JumpForce = 500f;

	private float maxVelocityXZ = 10f;
	private float SpeedRotation = 5f;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	public void Moving(Vector3 direction)
	{
		float velocityXZ = Mathf.Sqrt(rb.velocity.x * rb.velocity.x + rb.velocity.z * rb.velocity.z);
		if (velocityXZ < maxVelocityXZ)
			rb.AddForce(direction * Speed);
	}

	public void Rotating(Vector3 axis)
	{
		transform.Rotate(axis * SpeedRotation);
	}

	public void Jumping()
	{
		rb.AddForce(rb.transform.up * JumpForce);
	}

	public void PutABomb()
	{
		Vector3 bombPosition = transform.position + 2 * (transform.localRotation * Vector3.forward);
		bombPosition.y = 0;
		Instantiate(Bomb, bombPosition, Quaternion.identity);
	}
}
