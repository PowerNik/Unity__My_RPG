using UnityEngine;

[System.Serializable]
public class Monster
{
	[SerializeField] private MonsterType monsterType = MonsterType.Zombie;
	[SerializeField] private GameObject prefab;

	[SerializeField] private float health = 100;
	[SerializeField] private float speed = 5;
	[SerializeField] private float damage = 10;

	[SerializeField] private float agroRadius = 30;
	[SerializeField] private float attackRadius = 10;
	[SerializeField] private float visibleRadius = 1;

	[SerializeField] private float mass = 1;
	[SerializeField] private bool isFly = false;

	public MonsterType MonsterType { get { return monsterType; } }
	public GameObject Prefab { get { return prefab; } }

	public float Health { get { return health; } }
	public float Speed { get { return speed; } }
	public float Damage { get { return damage; } }

	public float AgroRadius { get { return agroRadius; } }
	public float AttackRadius { get { return attackRadius; } }
	public float VisibleRadius { get { return visibleRadius; } }

	public float Mass { get { return mass; } }
	public bool IsFly { get { return isFly; } }
}
