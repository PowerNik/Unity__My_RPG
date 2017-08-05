using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Bullet", menuName = "My Scriptable Objects/Bullet Settings", order = 2)]
public class BulletScriptableObject : ScriptableObject
{
	[SerializeField] private Bullet[] bullets;

	public Bullet GetBulletSettings(BulletType type)
	{
		foreach(var bullet in bullets)
		{
			if(bullet.BulletType == type)
			{
				return bullet;
			}
		}

		return bullets[0];
	}
}

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