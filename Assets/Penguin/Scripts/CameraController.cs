using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform LookAt;
	public Transform pivot;

	float scrollSpeed = 5;
	float sensX = 3;
	float sensY = 3;

	float distance = 7;
	float saveDistance;
	const float MIN_CAMERA_DISTANCE = 3;
	const float MAX_CAMERA_DISTANCE = 10;

	float angleX = 0;
	float angleY = 30;
	float savedY;
	const float MIN_ANGLE_Y = -5;
	const float MAX_ANGLE_Y = 80;

	bool isRotateAround = false;

	public bool IsRotateAround { get { return isRotateAround; } }

	void Update()
	{
		MoveCamera();
		ScrollZoom();

		if (isRotateAround == false)
			transform.position = Vector3.MoveTowards(transform.position, pivot.position, Time.deltaTime * 40);
	}

	void LateUpdate()
	{
		FollowTheTarget();

		transform.LookAt(LookAt.position + Vector3.up * 2);
	}

	public void RotateAround(bool flag)
	{
		isRotateAround = flag;
		if (flag == true)
		{
			angleX = LookAt.rotation.eulerAngles.y;
			savedY = angleY;
			saveDistance = distance;
		}
		else
		{
			distance = saveDistance;
			angleY = savedY;
		}
	}

	void MoveCamera()
	{
		if (isRotateAround)
		{
			angleX += Input.GetAxis("Mouse X") * sensX;
		}

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
		if (isRotateAround == false)
		{
			Quaternion rotation = Quaternion.Euler(angleY, 0, 0);
			pivot.localPosition = rotation * offset;
		}
		else
		{
			Quaternion rotation = Quaternion.Euler(angleY, angleX, 0);
			transform.position = LookAt.position + rotation * offset;
		}
	}
}
