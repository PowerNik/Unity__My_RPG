using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingManager : MonoBehaviour
{
	[SerializeField] private PacketScriptableObject packetSettings;
	[SerializeField] private BulletScriptableObject bulletSettings;
	[SerializeField] private WeaponScriptableObject weaponSettings;
//	[SerializeField] private MonsterScriptableObject monsterSettings;

	public Packet GetPacketSettings(PacketType type)
	{
		return packetSettings.GetPacketSettings(type);
	}

	public Bullet GetBulletSettings(BulletType type)
	{
		return bulletSettings.GetBulletSettings(type);
	}

	public Weapon GetWeaponSettings(WeaponType type)
	{
		return weaponSettings.GetWeaponSettings(type);
	}

	/*public Monster GetMonsterSettings(MonsterType type)
	{
		return monsterSettings.GetMonsterSettings(type);
	}*/
}
