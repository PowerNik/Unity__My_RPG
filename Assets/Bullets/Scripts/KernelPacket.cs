using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class KernelPacket : AbstractPacket
	{
		Collision collision;

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
