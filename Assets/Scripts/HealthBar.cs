using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void voidDelegate();

public class HealthBar : MonoBehaviour
{
	[SerializeField]
	private Health health;

	private Slider hpBar;

	void Start()
	{
		hpBar = gameObject.GetComponent<Slider>();

		hpBar.maxValue = health.MaxHP;
		hpBar.minValue = health.MinHP;
		hpBar.value = health.CurrentHP;
	}

	void Update()
	{
		hpBar.value = health.CurrentHP;
	}
}
