using UnityEngine;

[System.Serializable]
public class Packet
{
	[SerializeField] private PacketType packetType;
	[SerializeField] private GameObject prefab;

	[SerializeField] private float damage = 10;
	[SerializeField] private float speed = 50;
	[SerializeField] private float mass = 0.01f;
	[SerializeField] private float lifeTime = 2f;

	[Tooltip("Исчезает после столкновения с любым объектом?")]
	[SerializeField]
	private bool isDisappearAfterCollision = true;

	[Tooltip("Исчезает сразу после нанесения урона?")]
	[SerializeField]
	private bool isDestroyAfterDamaging = true;

	[Tooltip("Может быть разрушена другими снарядами?")]
	[SerializeField]
	private bool isDestroyable = false;

	[Tooltip("Урон, необходимый для уничтожения этого снаряда")]
	[SerializeField]
	private float hardness = 0;


	public PacketType PacketType { get { return packetType; } }
	public GameObject Prefab { get { return prefab; } }

	public float Damage { get { return damage; } }
	public float Speed { get { return speed; } }
	public float Mass { get { return mass; } }
	public float LifeTime { get { return lifeTime; } }

	public bool IsDisappearAfterCollision { get { return isDisappearAfterCollision; } }
	public bool IsDestroyAfterDamaging { get { return isDestroyAfterDamaging; } }
	public bool IsDestroyable { get { return isDestroyable; } }
	public float Hardness { get { return hardness; } }
}