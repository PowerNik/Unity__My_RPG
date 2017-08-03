using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
	protected bool isDead = false;

	private void Start()
	{
		gameObject.GetComponent<Health>().OnDeath += OnDeath;
	}

	void Update()
	{
		if(isDead)
		{
			TakeDeath();
		}
	}

	void OnDeath()
	{
		isDead = true;
	}

	protected virtual void TakeDeath()
	{
		StartCoroutine("Fade");
	}

	IEnumerator Fade()
	{
		for (float alpha = 1f; alpha >= 0; alpha -= 0.05f)
		{
			Color color = GetComponent<Renderer>().material.color;
			color.a = alpha;
			GetComponent<Renderer>().material.color = color;
			yield return null;
		}

		Destroy(gameObject);
		yield return null;
	}
}
