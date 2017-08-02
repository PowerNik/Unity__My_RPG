using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class HomingMover : AbstractMover
	{
		bool isHoming = false;
		Vector3 aimPos;

		public override void Move(Vector3 startPos, Vector3 direction, Vector3 aim)
		{
			packet = GetComponent<AbstractPacket>();
			rb = GetComponent<Rigidbody>();

			aimPos = aim;
			isHoming = true;
		}

		void FixedUpdate()
		{
			if (isHoming)
			{
				float dash = Time.deltaTime * packet.Speed;
				transform.position = Vector3.MoveTowards(transform.position, aimPos, dash);
			}
		}
	}
}
