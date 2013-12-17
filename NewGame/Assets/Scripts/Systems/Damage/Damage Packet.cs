using UnityEngine;
using System.Collections;

public class DamagePacket : MonoBehaviour {
	//the numerical damage of the packet
	private int damage;
	//the type of damage (special)
	private DamageTypes type;

	//returns the damage value
	public int getDamage(){
		return damage;
	}

	//returns the type of damage
	public char getType(){
		return type;
	}
}
