using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Packet", menuName = "My Scriptable Objects/Packet Settings", order = 3)]
public class PacketScriptableObject : ScriptableObject
{
	public Packet[] packets;
}

[System.Serializable]
public class Packet
{
	public PacketType type;
	public GameObject prefab;

	public float damage = 10;
	public float speed = 50;
	public float mass = 0.01f;
}
