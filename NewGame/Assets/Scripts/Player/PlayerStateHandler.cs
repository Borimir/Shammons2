﻿using UnityEngine;
using System.Collections.Generic;

public class PlayerStateHandler : MonoBehaviour {
	private PlayerStats pStats;
	void Start(){
		pStats = ((PlayerStats)(this.gameObject.GetComponent("PlayerStats")));
	}
	
	public void handleAttackPacket(AttackPacket packet){
		Debug.Log (packet.getAttackPacket().Count.ToString());
		packet.getAttackPacket().ForEach(delegate(DamagePacket dpack){
			handleDamagePacket(dpack);
		});

	}

	public void handleDamagePacket(DamagePacket packet){
		float value = 0;
		Dictionary<string,float> rTable = pStats.getDRTable();
		rTable.TryGetValue(packet.getDI(),out value);
		int damage = ((int)((packet.getDamage()/(value))));
		pStats.setHealth(pStats.getHealth()-damage);
	}
}
