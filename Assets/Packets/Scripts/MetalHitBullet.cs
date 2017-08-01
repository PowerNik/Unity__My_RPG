using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Packets
{
	public class MetalHitBullet : AbstractBullet
	{
		public Transform MetalHit;

		Collider other;
		Collision collision;

		public override float Damage { get { return 10; } }
		public override float Mass { get { return 0.1f; } }
		public override float Speed { get { return 50; } }

		private void OnTriggerEnter(Collider _other)
		{
			other = _other;

			DoAttack();
			Destroy(gameObject);
		}

		private void OnCollisionEnter(Collision collision)
		{
			this.collision = collision;

			DoAttack();
			Destroy(gameObject);
		}

		public override void DoAttack()
		{
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, collision.contacts[0].normal);
			Instantiate(MetalHit, collision.contacts[0].point, rot);
		}
	}
}
