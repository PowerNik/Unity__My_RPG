using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Packet", menuName = "My Scriptable Objects/Packet Settings", order = 3)]
public class PacketScriptableObject : ScriptableObject
{
	[SerializeField] private Packet[] packets;

	public Packet GetPacketSettings(PacketType type)
	{
		foreach (var packet in packets)
		{
			if (packet.PacketType == type)
			{
				return packet;
			}
		}

		return packets[0];
	}
}
