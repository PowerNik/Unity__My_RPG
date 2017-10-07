using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : CharacterController
{
	bool isDiyng = false;
	GameObject target;
	float lastTimeAttack;
	float attackSpeed = 1;
	MonsterType type = MonsterType.Zombie;

	protected override void IAmStart()
	{
		GameManager.CharacterStart(myCharType, gameObject);
		GameManager.SettingManager.GetMonsterSettings(type);
	}

	void Update()
	{
		if (isDiyng)
		{
			return;
		}

		GameObject enemy = GameManager.GetNearestEnemy(myCharType, transform);
		if (enemy == null)
		{
			Destroy(enemy);
			return;
		}

		Vector3 offset = enemy.transform.position - transform.position;
		//TODO
		if (offset.magnitude < 20)
		{
			target = enemy;
			ArgoTriggered();
		}
	}

	protected override void Diyng()
	{
		isDiyng = true;
		GameManager.CharacterDead(myCharType, gameObject);
	}

	private void ArgoTriggered()
	{
		Vector3 offset = target.transform.position - transform.position;

		Rotating(offset.normalized);
		//TODO
		if (offset.magnitude > 10)
		{
			Moving(offset.normalized);
		}
		else
		{
			DoAttack();
		}
	}

	private void Rotating(Vector3 direction)
	{
		/*Quaternion rot = Quaternion.FromToRotation(Vector3.forward, direction);
		rot.x = rot.z = 0;
		transform.rotation = rot;*/
	}

	public override void DoAttack()
	{
		//GetComponent<Shooting>().Shoot((target.transform.position - transform.position).normalized);
		if (Time.time > lastTimeAttack + attackSpeed)
		{
			lastTimeAttack = Time.time;
			GetComponent<Shooting>().Shoot();
		}
	}
}
