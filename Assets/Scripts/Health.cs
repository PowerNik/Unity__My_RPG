using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void Death();

public class Health : MonoBehaviour
{
	public event Death OnDeath;

	private float currentHP = 100;
	private float minHP = 0;
	private float maxHP = 100;

	public float CurrentHP { get { return currentHP; } }
	public float MinHP { get { return minHP; } }
	public float MaxHP { get { return maxHP; } }

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			TakeDamage(10);
		}

		if (Input.GetKey(KeyCode.Alpha2))
		{
			TakeHeal(0.5f);
		}
	}

	public void TakeDamage(float damage)
	{
		if (damage > 0)
		{
			currentHP -= damage;
		}

		if (currentHP < minHP)
		{
			currentHP = minHP;
		}

		if (currentHP == 0)
		{
			OnDeath();
		}
	}

	public void TakeHeal(float heal)
	{
		if (heal > 0)
		{
			currentHP += heal;
		}

		if (currentHP > maxHP)
		{
			currentHP = maxHP;
		}
	}
}
