using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Bullet", menuName = "My Scriptable Objects/Bullet Settings", order = 2)]
public class BulletScriptableObject : ScriptableObject
{
	public Bullet[] Bullets;
}

[System.Serializable]
public class Bullet
{
	public string bulletName;
	public BulletType bulletType = BulletType.LinearLaserBullet;

	public MoverType moverType = MoverType.LinearMover;
	public PacketType packetType = PacketType.LaserPacket;
}