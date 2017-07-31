using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Packets
{
	public class HomingMover : AbstractMover
	{
		bool isHoming = false;
		Vector3 aimPos;

		public override void Move(Vector3 startPos, Vector3 direction, Vector3 aim)
		{
			bullet = GetComponent<AbstractBullet>();
			rb = GetComponent<Rigidbody>();

			aimPos = aim;
			isHoming = true;
		}

		void FixedUpdate()
		{
			if (isHoming)
			{
				float dash = Time.deltaTime * bullet.Speed;
				transform.position = Vector3.MoveTowards(transform.position, aimPos, dash);
			}
		}
	}
}
