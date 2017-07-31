using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Packets
{
	public class LinearMover : AbstractMover
	{
		public override void Move(Vector3 startPos, Vector3 direction, Vector3 aimPos)
		{
			bullet = GetComponent<AbstractBullet>();
			rb = gameObject.GetComponent<Rigidbody>();

			rb.mass = bullet.Mass;
			rb.useGravity = false;

			rb.AddForce(direction.normalized * bullet.Speed, ForceMode.VelocityChange);
		}
	}
}
