using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EventSource : MonoBehaviour {


	private long timeBetweenHits;
	private GameObject player;
	private AttackPacket proxAttackPacket;

	void Start () {
		player = GameObject.Find("Player");
		List<DamagePacket> damageList = new List<DamagePacket>();
		damageList.Add(new DamagePacket(DamageType.RANGED,SpecialType.PIERCING,10));
		proxAttackPacket = new AttackPacket(damageList);
	}


	void FixedUpdate () {
		if(Vector3.Distance(player.transform.position,this.gameObject.transform.position)<10){
			player.SendMessage("handleAttackPacket",proxAttackPacket);
		}
	
	}
}
