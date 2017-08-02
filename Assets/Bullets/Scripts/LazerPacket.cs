using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public class LazerPacket : AbstractPacket
	{
		Collider other;

		public override float Damage { get { return 10; } }
		public override float Mass { get { return 0.1f; } }
		public override float Speed { get { return 50; } }

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
