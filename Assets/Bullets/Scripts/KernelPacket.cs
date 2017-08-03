using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class KernelPacket : AbstractPacket
	{
		Collision collision;

		public override float Damage { get { return 20; } }
		public override float Mass { get { return 5; } }
		public override float Speed { get { return 100; } }

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
