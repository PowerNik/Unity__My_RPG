using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private static Dictionary<CharacterType, List<GameObject>> CharacterDict = new Dictionary<CharacterType, List<GameObject>>();

	public static void CharacterStart(CharacterType type, GameObject myGameObject)
	{
		if (CharacterDict.ContainsKey(type) == false)
		{
			CharacterDict.Add(type, new List<GameObject>());
		}
		CharacterDict[type].Add(myGameObject);
	}

	public static void CharacterDead(CharacterType type, GameObject myGameObject)
	{
		if (CharacterDict.ContainsKey(type))
		{
			if (CharacterDict[type].Contains(myGameObject))
			{
				CharacterDict[type].Remove(myGameObject);

				if (CharacterDict[type].Count == 0)
				{
					CharacterDict.Remove(type);
				}
			}
		}
	}

	public static GameObject GetCharacter(CharacterType type)
	{
		if (CharacterDict.ContainsKey(type))
		{
			return CharacterDict[type][0];
		}
		else
			return new GameObject("null");
	}

	public static GameObject[] GetCharacterList(CharacterType type)
	{
		if (CharacterDict.ContainsKey(type))
		{
			return CharacterDict[type].ToArray();
		}
		else
			return new GameObject[] { };
	}

	public static GameObject GetNearestEnemy(CharacterType myType, Transform myTransform)
	{
		GameObject nearestEnemy = null;
		float distance = 100000;

		foreach (var pair in CharacterDict)
		{
			if (pair.Key == myType || pair.Key == CharacterType.NPC)
			{
				continue;
			}

			float tempDistance;
			foreach (var GO in pair.Value)
			{
				tempDistance = (GO.transform.position - myTransform.position).magnitude;
				if (tempDistance < distance)
				{
					distance = tempDistance;
					nearestEnemy = GO;
				}
			}
		}

		return nearestEnemy;
	}

	public static GameObject[] GetEnemyInRadius(CharacterType myType, Transform myTransform, float radius)
	{
		List<GameObject> enemyInRadius = new List<GameObject>();

		foreach (var pair in CharacterDict)
		{
			if (pair.Key == myType || pair.Key == CharacterType.NPC)
			{
				continue;
			}

			float tempDistance;
			foreach (var GO in pair.Value)
			{
				tempDistance = (GO.transform.position - myTransform.position).magnitude;
				if (tempDistance < radius)
				{
					enemyInRadius.Add(GO);
				}
			}
		}

		return enemyInRadius.ToArray();
	}
}
