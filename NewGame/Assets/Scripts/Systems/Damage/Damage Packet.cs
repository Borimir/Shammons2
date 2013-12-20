using UnityEngine;
using System.Collections;

public class DamagePacket{
	//the numerical damage of the packet
	private float damage;
	private string di;
	

	public DamagePacket(string di,float damage){
		this.damage = damage;
		this.di = di;
	}

	//returns the damage value
	public float getDamage(){
		return damage;
	}
	
	public string getDI(){
		return di;
	}
}
