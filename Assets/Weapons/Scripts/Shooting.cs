using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bullets;

public class Shooting : MonoBehaviour
{
	public Transform CameraPos;
	public Transform SpawnPos;
	RaycastHit HIT;
	public GameObject packet;

	void Shoot()
	{
		Vector3 startPos = SpawnPos.position;
		Physics.Raycast(CameraPos.position, CameraPos.forward, out HIT);

		Vector3 direction = (HIT.point - startPos).normalized;
		if (HIT.collider == null)
		{
			direction = CameraPos.forward;
		}

		GameObject packetGO = Instantiate(packet, startPos, this.transform.rotation);
		packetGO.GetComponent<AbstractMover>().Move(startPos, direction);
	}

	private void Update()
	{
		if (Input.GetMouseButtonUp(0))
		{
			Shoot();
		}
	}
}
