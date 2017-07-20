using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLifetime : MonoBehaviour
{
	public float LifeTime = 2f;
	private float Timer;

	void Start()
	{
		Timer = LifeTime;
	}

	// Update is called once per frame
	void Update()
	{
		Timer = (Timer - Time.deltaTime > 0) ? Timer - Time.deltaTime : 0;
		if (Timer == 0)
		{
			Timer = LifeTime;
			Destroy(gameObject);
		}
	}
}
