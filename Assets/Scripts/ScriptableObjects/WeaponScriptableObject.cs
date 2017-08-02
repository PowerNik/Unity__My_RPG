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
	public WeaponType type;
	public Texture icon;
	public int particle;
	public GameObject prefab;
	public GameObject bullet;
}