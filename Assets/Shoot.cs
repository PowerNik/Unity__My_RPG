using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Packets;

public class Shoot : MonoBehaviour
{
	public Transform CameraPos;
	public Transform SpawnPos;
	RaycastHit HIT;
	public GameObject packet;

	void ShootMe()
	{
		Vector3 startPos = SpawnPos.position;
		GameObject T;

		Physics.Raycast(CameraPos.position, CameraPos.forward, out HIT);
		Vector3 direction = (HIT.point - startPos).normalized;

		T = Instantiate(packet, startPos, Quaternion.Euler(direction));
		T.GetComponent<AbstractMover>().Move(startPos, direction);
	}

	private void Update()
	{
		if (Input.GetMouseButtonUp(0))
			ShootMe();
	}
}
