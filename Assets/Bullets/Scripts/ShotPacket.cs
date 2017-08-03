using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class ShotPacket : AbstractPacket
	{
		Collider other;

		public override float Damage { get { return 10; } }
		public override float Mass { get { return 0.1f; } }
		public override float Speed { get { return 30; } }

		private void OnTriggerEnter(Collider other)
		{
			this.other = other;
			DoAttack();
		}

		public override void DoAttack()
		{
			if (other.gameObject.tag == "Enemy")
			{
				DoDamage();
			}
		}

		private void DoDamage()
		{
			Health hp = other.gameObject.GetComponent<Health>();
			if (hp)
			{
				hp.TakeDamage(Damage);
				Destroy(gameObject);
			}
		}
	}
}
