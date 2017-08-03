using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : Death
{
	protected override void TakeDeath()
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

		yield return new WaitForSeconds(1f);

		isDead = false;

		Color col = GetComponent<Renderer>().material.color;
		col.a = 1f;
		GetComponent<Renderer>().material.color = col;

		GetComponent<Rigidbody>().MovePosition(new Vector3(150, 5, 150));
		GetComponent<Rigidbody>().MoveRotation(Quaternion.identity);

		yield return null;
	}
}
