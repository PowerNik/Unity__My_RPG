using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Packets
{
	public class RayMover : AbstractMover
	{
		public override void Move(Vector3 startPos, Vector3 direction, Vector3 aimPos)
		{
			bullet = GetComponent<AbstractBullet>();
			rb = GetComponent<Rigidbody>();

			RaycastHit hit;

			if (Physics.Raycast(startPos, direction, out hit))
				transform.position = hit.transform.position;
		}
	}
}
