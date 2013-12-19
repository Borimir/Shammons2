using UnityEngine;
using System.Collections.Generic;
public class AttackPacket : MonoBehaviour {
	private List<DamagePacket> damagePackets;

	public AttackPacket(List<DamagePacket> list){
		this.damagePackets = list;
	}

	public List<DamagePacket> getAttackPacket(){
		return damagePackets;
	}
}
