using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBomb : MonoBehaviour
{
	public float power = 5f;
	public float radius = 5f;
	public float upForce = 5f;


	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.F))
		{
			Invoke("MakeAnExplosion", 0.3f);
		}
	}

	void MakeAnExplosion()
	{
		Vector3 explosionPosition = transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);

		foreach (Collider col in colliders)
		{
			Rigidbody rb = col.GetComponent<Rigidbody>();
			if (rb != null)
				rb.AddExplosionForce(power, explosionPosition, radius, upForce, ForceMode.Impulse);
		}

		Destroy(gameObject);
	}
}
