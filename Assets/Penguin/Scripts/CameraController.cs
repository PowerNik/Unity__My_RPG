using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject obj;

	private Vector3 MousePos;
	public float sensitivity = 1f;
	float MyAngleUp = 0f;
	float MyAngleRight = 0f;

	// Update is called once per frame
	void Update()
	{
		MousePos = Input.mousePosition;
	}

	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.RotateAround(obj.transform.position, transform.up, 1f);

		if (Input.GetKey(KeyCode.RightArrow))
			transform.RotateAround(obj.transform.position, transform.up, -1f);

		if (Input.GetKey(KeyCode.UpArrow))
			transform.RotateAround(obj.transform.position, transform.right, 1f);

		if (Input.GetKey(KeyCode.DownArrow))
			transform.RotateAround(obj.transform.position, transform.right, -1f);

		float dis = Input.GetAxis("Mouse ScrollWheel");
		transform.position += transform.forward * dis * 3;
	}
}
