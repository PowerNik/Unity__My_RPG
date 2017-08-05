using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Weapon", menuName = "My Scriptable Objects/Weapon Settings", order = 1)]
public class WeaponScriptableObject : ScriptableObject
{
	[SerializeField] private Weapon[] weapons;

	public Weapon GetWeaponSettings(WeaponType type)
	{
		foreach (var weapon in weapons)
		{
			if (weapon.WeaponType == type)
			{
				return weapon;
			}
		}

		return weapons[0];
	}
}

[System.Serializable]
public class Weapon
{
	[SerializeField] private string weaponName = "My Gun";
	[SerializeField] private Texture icon;
	[SerializeField] private GameObject prefab;

	[SerializeField] private WeaponType weaponType = WeaponType.LaserGun;
	[SerializeField] private BulletType bulletType = BulletType.LinearLaserBullet;

	[Range(1, 1000)]
	[SerializeField]
	private int capacity = 100;
	[Range(0, 10)]
	[SerializeField]
	private float coolDown = 1f;
	[Range(0, 45)]
	[SerializeField]
	private float dispersionAngle = 10;

	[SerializeField] private bool isAutomatic = false;
	[SerializeField] private bool isCollimator = false;


	public Texture Icon { get { return icon; } }
	public GameObject Prefab { get { return prefab; } }

	public WeaponType WeaponType { get { return weaponType; } }
	public BulletType BulletType { get { return bulletType; } }

	public int Capacity { get { return capacity; } }
	public float CoolDown { get { return coolDown; } }
	public float DispersionAngle { get { return dispersionAngle; } }

	public bool IsAutomatic { get { return isAutomatic; } }
	public bool IsCollimator { get { return isCollimator; } }
}