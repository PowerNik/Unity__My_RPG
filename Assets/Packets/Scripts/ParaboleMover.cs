using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Packets
{
	public class ParaboleMover : AbstractMover
	{
		public override void Move(Vector3 startPos, Vector3 direction, Vector3 aimPos)
		{
			bullet = GetComponent<AbstractBullet>();
			rb = GetComponent<Rigidbody>();

			rb.AddForce(direction.normalized * bullet.Speed, ForceMode.Impulse);
		}
	}
}
