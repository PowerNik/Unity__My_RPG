using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public Slider hpBar;

	public float currentHP = 100;
	private float minHP = 0;
	private float maxHP = 100;

	// Use this for initialization
	void Start()
	{
		hpBar.maxValue = maxHP;
		hpBar.minValue = minHP;
		hpBar.value = currentHP;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			MakeDamage(10);
		}

		if (Input.GetKey(KeyCode.Alpha2))
		{
			MakeHeal(0.5f);
		}
	}

	public void MakeDamage(float damage)
	{
		if (damage > 0)
		{
			currentHP -= damage;
		}

		if (currentHP < minHP)
		{
			currentHP = minHP;
		}

		hpBar.value = currentHP;
	}

	public void MakeHeal(float heal)
	{
		if (heal > 0)
		{
			currentHP += heal;
		}

		if (currentHP > maxHP)
		{
			currentHP = maxHP;
		}

		hpBar.value = currentHP;
	}
}
