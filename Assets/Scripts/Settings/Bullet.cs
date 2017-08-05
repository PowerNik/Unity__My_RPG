using UnityEngine;

[System.Serializable]
public class Bullet
{
	[SerializeField] private string bulletName = "Bullet";

	[SerializeField] private BulletType bulletType = BulletType.LinearLaserBullet;
	[SerializeField] private MoverType moverType = MoverType.LinearMover;
	[SerializeField] private PacketType packetType = PacketType.LaserPacket;

	public BulletType BulletType { get { return bulletType; } }
	public MoverType MoverType { get { return moverType; } }
	public PacketType PacketType { get { return packetType; } }
}
