using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bullets;

public class PlayerShooting : Shooting
{
	public Transform cameraPos;
	private RaycastHit HIT;

	protected override void SetDirection()
	{
		Physics.Raycast(cameraPos.position, cameraPos.forward, out HIT);
		direction = (HIT.point - spawnPos.position).normalized;

		if (HIT.collider == null)
		{
			direction = cameraPos.forward;
		}
	}

	private void Update()
	{
		if (Input.GetMouseButtonUp(0))
		{
			Shoot();
		}
	}
}
