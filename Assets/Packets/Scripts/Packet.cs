using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Packets
{
	public class Packet : MonoBehaviour
	{
		[SerializeField]
		AbstractBullet bullet;

		[SerializeField]
		AbstractMover mover;

		public Rigidbody rb;

		private void Start()
		{
			rb = GetComponent<Rigidbody>();

			if(bullet && rb)
			{
				rb.mass = bullet.Mass;
			}
		}

		public void CreatePacket(AbstractBullet bullet, AbstractMover mover)
		{
			this.bullet = bullet;
			this.mover = mover;
		}

		public void Move(Vector3 startPos, Vector3 aimPos)
		{
			rb.mass = bullet.Mass;
			mover.Move(startPos, aimPos);
		}
	}
}
