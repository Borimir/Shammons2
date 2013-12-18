using UnityEngine;
using System.Collections;

public class DamagePacket : MonoBehaviour {
	//the numerical damage of the packet
	private float damage;
	//the type of damage (special)
	private DamageType type;
	private SpecialType special;

	//returns the damage value
	public float getDamage(){
		return damage;
	}

	//returns the type of damage 
	public DamageType getType(){
		return type;
	}

	public TreeType treeType(DamageType type){
		switch(type){
		case DamageType.MELEE:
			return TreeType.PHYSICAL;
		case DamageType.RANGED:
			return TreeType.PHYSICAL;
		case DamageType.CHAOS:
			return TreeType.MAGICAL;
		case DamageType.ELEMENTAL:
			return TreeType.MAGICAL;
		case DamageType.NATURAL:
			return TreeType.MAGICAL;
		default: 
				Debug.Log("Something's wrong here!");
				return TreeType.MAGICAL;
		}
	}
	public SpecialType getSpecialType(){
		return special;
	}
}
