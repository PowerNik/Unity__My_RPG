using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform playerPosition;

	float scrollSpeed = 5f;
	float sensX = 3f;
	float sensY = 3f;

	const float MIN_CAMERA_DISTANCE = 3f;
	const float MAX_CAMERA_DISTANCE = 15f;
	const float MIN_ANGLE_Y = 0;
	const float MAX_ANGLE_Y = 90;

	void LateUpdate()
	{
		MoveCamera();
		ScrollZoom();
	}

	void MoveCamera()
	{
		if (Input.GetKey(KeyCode.L))
			Debug.Break();

		float newAngleY = -Input.GetAxis("Mouse Y") * sensY + transform.rotation.eulerAngles.x;

		if (MIN_ANGLE_Y < newAngleY && newAngleY < MAX_ANGLE_Y)
			transform.RotateAround(playerPosition.transform.position, transform.right, -Input.GetAxis("Mouse Y") * sensY);

		transform.RotateAround(playerPosition.transform.position, Vector3.up, Input.GetAxis("Mouse X") * sensX);
	}

	void ScrollZoom()
	{
		Vector3 newPos = transform.localPosition +
			transform.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;

		if (MIN_CAMERA_DISTANCE < -newPos.z && -newPos.z < MAX_CAMERA_DISTANCE)
			transform.localPosition = newPos;
	}
}
