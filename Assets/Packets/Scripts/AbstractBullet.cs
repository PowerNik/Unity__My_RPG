using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Packets
{
	public abstract class AbstractBullet : MonoBehaviour
	{
		public virtual float Damage { get { return 100; } }

		public virtual float Speed { get { return 10; } }

		public virtual float Mass { get { return 1; } }	

		public abstract void DoAttack();
	}
}
