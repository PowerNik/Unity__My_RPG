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

		Physics.Raycast(CameraPos.position, CameraPos.forward, out HIT);

		Vector3 direction = (HIT.point - startPos).normalized;
		if (HIT.collider == null)
			direction = CameraPos.forward;

		GameObject T = Instantiate(packet, startPos, this.transform.rotation);
		T.GetComponent<AbstractMover>().Move(startPos, direction);
	}

	private void Update()
	{
		if (Input.GetMouseButtonUp(0))
			ShootMe();
	}
}
