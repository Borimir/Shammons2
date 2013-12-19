using UnityEngine;
using System.Collections;

public class DamagePacket : MonoBehaviour {
	//the numerical damage of the packet
	private float damage;
	//the type of damage
	private DamageType type;
	//the type of damage (special)
	private SpecialType special;


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

	public DamagePacket(DamageType type,SpecialType special,float damage){
		this.damage = damage;
		this.type = type;
		this.special = special;
	}

	//returns the damage value
	public float getDamage(){
		return damage;
	}
	
	//returns the type of damage 
	public DamageType getType(){
		return type;
	}

	//returns the special damage type
	public SpecialType getSpecialType(){
		return special;
	}
}
