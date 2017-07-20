using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float Speed = 10f;
	private float SpeedRotation = 5f;

	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		Moving();
	}

	void Moving()
	{
		float moveX = Input.GetAxis("Horizontal");
		float moveZ = Input.GetAxis("Vertical");

		rb.AddForce(new Vector3(moveX, 0f, moveZ) * Speed);

		if (Input.GetKey(KeyCode.Q))
		{
			rb.transform.Rotate(Vector3.down * SpeedRotation);
		}

		if (Input.GetKey(KeyCode.E))
		{
			rb.transform.Rotate(Vector3.up * SpeedRotation);
		}
	}
}
