using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Packets
{
	public abstract class AbstractMover : MonoBehaviour
	{
		protected AbstractBullet bullet;
		protected Rigidbody rb;

		public abstract void Move(Vector3 startPos, Vector3 direction, Vector3 aimPos = new Vector3());
	}
}
