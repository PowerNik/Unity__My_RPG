﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
	[SerializeField]
	PlayerController playerController;

	KeyCode TurnRightKey = KeyCode.E;
	KeyCode TurnLeftKey = KeyCode.Q;
	KeyCode JumpKey = KeyCode.Space;
	KeyCode PutABombKey = KeyCode.R;

	[SerializeField]
	GameObject InventoryPanel;
	KeyCode BackpackKey = KeyCode.I;
	bool isBackpackShown = false;

	private void Start()
	{
		InventoryPanel.SetActive(isBackpackShown);
	}

	private void Update()
	{
		PutABomb();
		JumpPlayer();
	}

	private void FixedUpdate()
	{
		MovePlayer();
		TurnPlayer();
	}

	private void LateUpdate()
	{
		ShowBackpack();
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

	void ShowBackpack()
	{
		if (Input.GetKeyDown(BackpackKey))
		{
			isBackpackShown = !isBackpackShown;
			InventoryPanel.SetActive(isBackpackShown);
		}
	}
}
