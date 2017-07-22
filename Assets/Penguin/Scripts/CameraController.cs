using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform targetPosition;

	float scrollSpeed = 1f;
	float sensX = 3f;
	float sensY = 3f;

	const float MIN_CAMERA_DISTANCE = 3f;
	const float MAX_CAMERA_DISTANCE = 10f;
	const float MIN_ANGLE_Y = -10;
	const float MAX_ANGLE_Y = 90;

	void LateUpdate()
	{
		MoveCamera();
		ScrollZoom();
	}

	void MoveCamera()
	{
		float newAngleY = -Input.GetAxis("Mouse Y") * sensY + transform.rotation.eulerAngles.x;
		if (newAngleY > 270)
			newAngleY -= 360;

		if(MIN_ANGLE_Y <= newAngleY && newAngleY <= MAX_ANGLE_Y)
			transform.RotateAround(targetPosition.transform.position, transform.right,
				-Input.GetAxis("Mouse Y") * sensY);

		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) ||
		Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
			targetPosition.rotation = targetPosition.rotation *
				Quaternion.Euler(0, Input.GetAxis("Mouse X") * sensX, 0);
		else
			transform.RotateAround(targetPosition.transform.position, Vector3.up,
										Input.GetAxis("Mouse X") * sensX);
	}

	void ScrollZoom()
	{
		Vector3 newPos = transform.localPosition * (1 - Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);

		if (MIN_CAMERA_DISTANCE < newPos.magnitude && newPos.magnitude < MAX_CAMERA_DISTANCE)
			transform.localPosition = newPos;
	}
}
