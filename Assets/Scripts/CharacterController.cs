using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
	[SerializeField]
	protected CharacterType myCharType = CharacterType.NPC;

	[SerializeField]
	private float Speed = 0.75f;
	[SerializeField]
	private float JumpForce = 5;

	[SerializeField]
	private float maxVelocityXZ = 10f;
	private float SpeedRotation = 3f;

	protected Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		GetComponent<Health>().OnDeath += Diyng;

		IAmStart();
	}

	protected virtual void IAmStart() { }

	protected virtual void Diyng() { }

	public virtual void Moving(Vector3 direction)
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

	public virtual void DoAttack() { }
}
