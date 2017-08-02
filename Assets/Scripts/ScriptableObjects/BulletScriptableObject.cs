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
	public BulletType type;
	public Texture icon;
	public int particle;
	public GameObject prefab;
	public GameObject bullet;
}