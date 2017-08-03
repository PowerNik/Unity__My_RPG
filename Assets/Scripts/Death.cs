using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
	private bool isDead = false;

	private void Start()
	{
		gameObject.GetComponent<Health>().OnDeath += OnDeath;
	}

	private void Update()
	{
		if(isDead)
		{
			StartCoroutine("Fade");
		}
	}

	private void OnDeath()
	{
		isDead = true;
	}

	IEnumerator Fade()
	{
		for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
		{
			Color color = GetComponent<Renderer>().material.color;
			color.a = alpha;
			GetComponent<Renderer>().material.color = color;
			yield return new WaitForSeconds(0.1f);
		}
		Destroy(gameObject);
		yield return null;
	}
}
