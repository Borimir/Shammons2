using UnityEngine;
using System.Collections.Generic;
public class AttackPacket : MonoBehaviour {
	private List<DamagePacket> damagePackets;

	public List<DamagePacket> getAttackPacket(){
		return damagePackets;
	}
}
