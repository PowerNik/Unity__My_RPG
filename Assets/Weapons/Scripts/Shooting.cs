using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bullets;

public class Shooting : MonoBehaviour
{
	public Transform spawnPos;
	public GameObject bullet;
	protected Vector3 direction;
	public Transform player;

	public void Shoot()
	{
		SetDirection();

		GameObject bulletGO = Instantiate(bullet, spawnPos.position, this.transform.rotation);

		bulletGO.GetComponent<AbstractMover>().Move(spawnPos.position, direction);
	}

	protected virtual void SetDirection()
	{
		//direction = spawnPos.forward;
		direction = -(transform.position - player.position).normalized;
	}
}
