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
			Destroy(gameObject);
		}

		public override void DoAttack()
		{
			if (other.gameObject.tag == "Enemy")
				Destroy(other.gameObject);
		}
	}
}
