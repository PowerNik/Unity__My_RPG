using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSpell : MonoBehaviour
{
	public float power = 10f;
	public float radius = 10f;
	public float upForce = 10f;


	void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.Mouse1))
			MakeAnExplosion();
	}

	void MakeAnExplosion()
	{
		Vector3 explosionPosition = transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);

		foreach (Collider col in colliders)
		{
			if (col.tag == "Player")
				continue;

			Rigidbody rb = col.GetComponent<Rigidbody>();
			if (rb != null)
				rb.AddExplosionForce(power, explosionPosition, radius, upForce, ForceMode.Impulse);
		}
	}
}
