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