using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSpell : MonoBehaviour
{
	public float power = 10f;
	public float radius = 5f;
	public float upForce = 1f;


	void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.F))
			MakeAnExplosion();
	}

	void MakeAnExplosion()
	{
		Vector3 explosionPosition = transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);

		foreach(Collider col in colliders)
		{
			Rigidbody rb = col.GetComponent<Rigidbody>();
			if (rb != null)
				rb.AddExplosionForce(power, explosionPosition, radius, upForce, ForceMode.Impulse);
		}
	}
}
