using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class ParaboleMover : AbstractMover
	{
		public override void Move(Vector3 startPos, Vector3 direction, Vector3 aimPos)
		{
			packet = GetComponent<AbstractPacket>();
			rb = GetComponent<Rigidbody>();

			rb.AddForce(direction.normalized * packet.Speed, ForceMode.Impulse);
		}
	}
}
