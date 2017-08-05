using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class ShotPacket : AbstractPacket
	{
		Collider other;

		private void OnTriggerEnter(Collider other)
		{
			this.other = other;
			DoAttack();
		}

		public override void DoAttack()
		{
			DoDamage();
			Destroy(gameObject);
		}

		private void DoDamage()
		{
			Health hp = other.gameObject.GetComponent<Health>();
			if (hp)
			{
				hp.TakeDamage(Damage);
			}
		}
	}
}
