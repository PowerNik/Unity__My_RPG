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