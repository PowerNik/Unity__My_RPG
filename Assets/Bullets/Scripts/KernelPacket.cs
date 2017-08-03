using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class KernelPacket : AbstractPacket
	{
		Collider other;

		public override float Damage { get { return 20; } }
		public override float Mass { get { return 5; } }
		public override float Speed { get { return 100; } }

		private void OnTriggerEnter(Collider _other)
		{
			other = _other;
			DoAttack();
		}

		public override void DoAttack()
		{
			DoDamage();
		}

		private void DoDamage()
		{
			Health hp = other.gameObject.GetComponent<Health>();
			if(hp)
			{
				hp.TakeDamage(Damage);
				Destroy(gameObject);
			}
		}
	}
}
