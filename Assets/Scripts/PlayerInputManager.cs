using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
	[SerializeField]
	private PlayerController playerController;

	private KeyCode TurnRightKey = KeyCode.E;
	private KeyCode TurnLeftKey = KeyCode.Q;
	private KeyCode JumpKey = KeyCode.Space;
	private KeyCode PutABombKey = KeyCode.R;

	void Update()
	{
		PutABomb();
		JumpPlayer();
	}

	void FixedUpdate()
	{
		MovePlayer();
		TurnPlayer();
	}

	void MovePlayer()
	{
		Vector3 direction = new Vector3(0, 0, 0);
		if (Input.GetKey(KeyCode.W))
			direction += playerController.transform.forward;

		if (Input.GetKey(KeyCode.S))
			direction -= playerController.transform.forward;

		if (Input.GetKey(KeyCode.D))
			direction += playerController.transform.right;

		if (Input.GetKey(KeyCode.A))
			direction -= playerController.transform.right;

		playerController.Moving(direction);
	}

	void TurnPlayer()
	{
		if (Input.GetKey(TurnRightKey))
			playerController.Rotating(Vector3.up);

		if (Input.GetKey(TurnLeftKey))
			playerController.Rotating(Vector3.down);
	}

	void JumpPlayer()
	{
		if (Input.GetKeyDown(JumpKey))
			playerController.Jumping();
	}

	void PutABomb()
	{
		if (Input.GetKeyDown(PutABombKey))
			playerController.PutABomb();
	}
}
