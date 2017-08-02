using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class RayCastMover : AbstractMover
	{
		public override void Move(Vector3 startPos, Vector3 direction, Vector3 aimPos)
		{
			packet = GetComponent<AbstractPacket>();
			rb = GetComponent<Rigidbody>();

			RaycastHit hit;

			if (Physics.Raycast(startPos, direction, out hit))
			{
				packet.SetParams(hit, direction);
				packet.DoAttack();
			}
		}
	}
}
