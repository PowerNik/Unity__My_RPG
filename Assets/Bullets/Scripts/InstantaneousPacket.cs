using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class InstantaneousPacket : AbstractPacket
	{
		public Transform bulletHolePrefab;

		private RaycastHit hit;
		private Vector3 direction;

		public override float Damage { get { return 10; } }
		public override float Mass { get { return 0.1f; } }
		public override float Speed { get { return 50; } }

		public override void DoAttack()
		{
			DoDamage();

			DoBulletHole();
			Interaction();

			Destroy(gameObject);
		}

		public override void SetParams(RaycastHit hit, Vector3 direction)
		{
			this.hit = hit;
			this.direction = direction;
		}

		private void DoDamage()
		{
			Health hp = hit.transform.GetComponent<Health>();
			if (hp)
			{
				hp.TakeDamage(Damage);
			}
		}

		private void DoBulletHole()
		{
			Quaternion rot = Quaternion.FromToRotation(Vector3.forward, hit.normal);
			Transform bulletHole = Instantiate(bulletHolePrefab, hit.point + hit.normal * 0.00001f, rot);
			bulletHole.parent = hit.transform;
		}

		private void Interaction()
		{
			Rigidbody rb = hit.transform.GetComponent<Rigidbody>();
			if (rb)
			{
				rb.AddForceAtPosition(direction * Speed, hit.point);
			}
		}
	}
}
