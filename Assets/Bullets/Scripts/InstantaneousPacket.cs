using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class InstantaneousPacket : AbstractPacket
	{
		public GameObject prefab;
		private RaycastHit hit;
		private Vector3 direction;

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
			Vector3 pos = hit.point + hit.normal * 0.00001f;

			Transform bulletHole = Instantiate(prefab.transform, pos, rot);
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
