using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

	public Rigidbody Bullet;
	public float Force = 15f;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Rigidbody temp = Instantiate(Bullet, transform.position, transform.rotation);
			temp.AddForce(transform.up * Force);
		}
	}
}
