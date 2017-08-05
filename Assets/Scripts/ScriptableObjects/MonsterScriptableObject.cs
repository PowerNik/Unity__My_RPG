using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Monster", menuName = "My Scriptable Objects/Monster Settings", order = 4)]
public class MonsterScriptableObject : ScriptableObject
{
	[SerializeField] private Monster[] monsters;

	public Monster GetMonsterSettings(MonsterType type)
	{
		foreach (var monster in monsters)
		{
			if (monster.MonsterType == type)
			{
				return monster;
			}
		}

		return monsters[0];
	}
}