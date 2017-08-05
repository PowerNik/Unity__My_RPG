using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class KernelPacket : AbstractPacket
	{
		Collision collision;

		public override float Damage { get { return 20; } }
		public override float Mass { get { return 0.5f; } }
		public override float Speed { get { return 50; } }

		private void Start()
		{
			Destroy(gameObject, 5f);
		}

		private void OnCollisionEnter(Collision collision)
		{
			this.collision = collision;
			DoAttack();
		}

		public override void DoAttack()
		{
			DoDamage();
		}

		private void DoDamage()
		{
			Health hp = collision.gameObject.GetComponent<Health>();
			if(hp)
			{
				hp.TakeDamage(Damage);
				Destroy(gameObject);
			}
		}
	}
}
