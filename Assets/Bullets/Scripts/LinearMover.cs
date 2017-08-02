using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class LinearMover : AbstractMover
	{
		public override void Move(Vector3 startPos, Vector3 direction, Vector3 aimPos)
		{
			packet = GetComponent<AbstractPacket>();
			rb = gameObject.GetComponent<Rigidbody>();

			rb.mass = packet.Mass;
			rb.useGravity = false;

			rb.AddForce(direction.normalized * packet.Speed, ForceMode.VelocityChange);
		}
	}
}
