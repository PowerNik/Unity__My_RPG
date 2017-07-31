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
		}

		public void CreatePacket(AbstractBullet _bullet, AbstractMover _mover)
		{
			bullet = _bullet;
			mover = _mover;
		}

		public void Move(Vector3 startPos, Vector3 aimPos)
		{
			rb.mass = bullet.Mass;
			mover.Move(startPos, aimPos);
		}
	}
}
