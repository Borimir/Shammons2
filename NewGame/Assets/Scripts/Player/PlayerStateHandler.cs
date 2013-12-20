using UnityEngine;
using System.Collections.Generic;

public class PlayerStateHandler : MonoBehaviour {
	private PlayerStats pStats;
	void OnStart(){
		pStats = ((PlayerStats)(this.gameObject.GetComponent("Player Stats")));
	}
	
	public void handleAttackPacket(AttackPacket packet){
		Debug.Log (packet.getAttackPacket().Count.ToString());
		//handleDamagePacket(packet.getAttackPacket()[0]);
		//packet.getAttackPacket().ForEach(handleDamagePackt);

	}

	public void handleDamagePacket(DamagePacket packet){
		float value = 0;
		Dictionary<string,float> rTable = pStats.getDRTable();
		rTable.TryGetValue(packet.getDI(),out value);
		int damage = ((int)((packet.getDamage()/(value))));
		pStats.setHealth(pStats.getHealth()-damage);
	}
}
