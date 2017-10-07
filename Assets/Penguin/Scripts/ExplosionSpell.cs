using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSpell : MonoBehaviour
{
	public float power = 15f;
	public float radius = 10f;
	public float upForce = 3f;

	public GameObject bomb;

	void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.Mouse1))
		{
			MakeAnExplosion();
		}

		if (Input.GetKeyDown(KeyCode.Mouse2))
		{
			MakeAnAttraction();
		}
	}

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.B))
		Instantiate(bomb, transform.position + transform.forward * 2, Quaternion.identity);
	}

	void MakeAnExplosion()
	{
		Vector3 explosionPosition = transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);

		foreach (Collider col in colliders)
		{
			if (col.tag == "Player")
			{
				continue;
			}

			Rigidbody rb = col.GetComponent<Rigidbody>();
			if (rb != null)
			{
				rb.AddExplosionForce(power, explosionPosition, radius, upForce, ForceMode.Impulse);
			}
		}
	}

	void MakeAnAttraction(float power = 15f, float radius = 25f, float upForce = 1f)
	{
		Vector3 explosionPosition = transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);

		foreach (Collider col in colliders)
		{
			if (col.tag == "Player")
			{
				continue;
			}

			Rigidbody rb = col.GetComponent<Rigidbody>();
			if (rb != null)
			{
				rb.AddExplosionForce(-power, explosionPosition, radius, -upForce, ForceMode.Impulse);
			}
		}
	}
}
