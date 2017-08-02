using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class Bullet : MonoBehaviour
	{
		[SerializeField]
		AbstractPacket packet;

		[SerializeField]
		AbstractMover mover;

		public Rigidbody rb;

		private void Start()
		{
			rb = GetComponent<Rigidbody>();

			if(packet && rb)
			{
				rb.mass = packet.Mass;
			}
		}

		public void CreateBullet(AbstractPacket packet, AbstractMover mover)
		{
			this.packet = packet;
			this.mover = mover;
		}

		public void Move(Vector3 startPos, Vector3 aimPos)
		{
			rb.mass = packet.Mass;
			mover.Move(startPos, aimPos);
		}
	}
}
