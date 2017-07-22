using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLifetime : MonoBehaviour
{
	public float LifeTime = 2f;

	void Start()
	{
		Destroy(gameObject, LifeTime);
	}
}
