using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform targetTransform;

	float scrollSpeed = 5;
	float sensX = 3;
	float sensY = 3;

	float distance = 7;
	const float MIN_CAMERA_DISTANCE = 3;
	const float MAX_CAMERA_DISTANCE = 15;

	float angleX = 0;
	float angleY = 30;
	const float MIN_ANGLE_Y = -5;
	const float MAX_ANGLE_Y = 90;

	void Update()
	{
		MoveCamera();
		ScrollZoom();
	}

	void LateUpdate()
	{
		FollowTheTarget();
	}

	void MoveCamera()
	{
		angleX += Input.GetAxis("Mouse X") * sensX;

		angleY -= Input.GetAxis("Mouse Y") * sensY;
		angleY = Mathf.Clamp(angleY, MIN_ANGLE_Y, MAX_ANGLE_Y);
	}

	void ScrollZoom()
	{
		distance -= Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
		distance = Mathf.Clamp(distance, MIN_CAMERA_DISTANCE, MAX_CAMERA_DISTANCE);
	}

	void FollowTheTarget()
	{
		Vector3 offset = new Vector3(0, 0, -distance);
		Quaternion rotation = Quaternion.Euler(angleY, angleX, 0);

		transform.position = targetTransform.position + rotation * offset;
		transform.LookAt(targetTransform.position);
	}
}
