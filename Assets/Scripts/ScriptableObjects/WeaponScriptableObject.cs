using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Weapon", menuName = "My Scriptable Objects/Weapon Settings", order = 1)]
public class WeaponScriptableObject : ScriptableObject
{
	public Weapon[] Weapons;
}

[System.Serializable]
public class Weapon
{
	public string weaponName = "My Gun";
	public WeaponType type = WeaponType.LaserGun;

	public GameObject prefab;
	public Texture icon;

	public BulletType bulletType = BulletType.LinearLaserBullet;

	public bool isAutomatic = false;
	public bool isCollimator = false;

	[Range(1, 1000)]
	public int Capacity = 100;
	[Range(0, 10)]
	public float coolDown = 1f;
	[Range(0, 45)]
	public float dispersionAngle = 10;
}