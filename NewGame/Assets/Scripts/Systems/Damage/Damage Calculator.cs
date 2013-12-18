using UnityEngine;
using System.Collections;

public class DamageCalculator{
	//returns the stat adjusted out going damage of a DamagePacket 
	public float atkAdjust(PlayerStats stats,DamagePacket packet){

		return
			//damage
			stats.getDamage()
			//TreeTypeDamage
			*(stats.getTreeDamage(packet.treeType(packet.getType())))
				//DamageTypeDamage
				*(stats.getDamageTypeDamage(packet.getType()))
                //Special Damage
				*(stats.getSpecialDamage(packet.getSpecialType()))
				//Raw Damage and its factor
				*(stats.getSpecialDamage(packet.getSpecialType()));
	}
	//returns the stat adjusted out going damage of an AttackPacket

	//returns a completed defense adjusted DamagePacket
	//uses atkAdjust

	//returns the completed defense adjusted AttackPacket
	//uses defAdjust
}
