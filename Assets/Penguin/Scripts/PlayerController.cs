using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public GameObject Bomb;
	public float Speed = 10f;
	public float JumpForce = 100f;

	private float SpeedRotation = 5f;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		Moving();
		Jumping();
		PutABomb();
	}

	void Moving()
	{
		if (Input.GetKey(KeyCode.W))
			rb.AddForce(rb.transform.forward * Speed);

		if (Input.GetKey(KeyCode.S))
			rb.AddForce(-rb.transform.forward * Speed);

		if (Input.GetKey(KeyCode.D))
			rb.AddForce(rb.transform.right * Speed);

		if (Input.GetKey(KeyCode.A))
			rb.AddForce(-rb.transform.right * Speed);


		if (Input.GetKey(KeyCode.Q))
			transform.Rotate(Vector3.down * SpeedRotation);

		if (Input.GetKey(KeyCode.E))
			transform.Rotate(Vector3.up * SpeedRotation);
	}

	void Jumping()
	{
		if (Input.GetKey(KeyCode.Space))
			rb.AddForce(rb.transform.up * JumpForce);
	}

	void PutABomb()
	{
		if (Input.GetKeyUp(KeyCode.R))
		{
			Vector3 bombPosition = transform.position + 2 * (transform.localRotation * Vector3.forward);
			bombPosition.y = 0;
			Instantiate(Bomb, bombPosition, Quaternion.identity);
		}
	}
}
