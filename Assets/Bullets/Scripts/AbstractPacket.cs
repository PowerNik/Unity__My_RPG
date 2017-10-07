using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
	public abstract class AbstractPacket : MonoBehaviour
	{
		protected Packet packet;
		protected PacketType packetType;

		public float Mass { get { return 5; /*packet.Mass;*/ } }
		public float Speed { get { return 5; /*packet.Speed;*/ } }
		public float Damage { get { return 5; /*packet.Damage;*/ } }

		protected void Start()
		{
			packet = GameManager.SettingManager.GetPacketSettings(packetType);
		}

		public abstract void DoAttack();

		public virtual void SetParams(RaycastHit hit, Vector3 direction) { }
	}
}
