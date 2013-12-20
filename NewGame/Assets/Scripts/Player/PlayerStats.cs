using UnityEngine;
using System.Collections.Generic;

public class PlayerStats : MonoBehaviour {

	public int health;

	//damage stats
	//factor damage
	private float damage,physical,melee,ranged,magical,chaos,elemental,natural;
	//special damage
	private float special,burn,poison,psychic,surge,ice,blunt,piercing,slashing;

	//defensive stats
	//factor defense
	private float damageResist,physicalResist,meleeResist,rangedResist,magicalResist,chaosResist,elementalResist,naturalResist;
    
	//special resistance
	private float specialResist,burnResist,poisonResist,psychicResist,surgeResist,iceResist,bluntResist,piercingResist,slashingResist;

	//other personal enhancements
	private float vitality,speed;


	private Dictionary<string,float> damageTable;
	private Dictionary<string,float> defenseTable = new Dictionary<string,float>();
	public Dictionary<string,float> getDTable(){
		return damageTable;
	}
	public Dictionary<string,float> getDRTable(){
		return defenseTable;
	}
	void OnAwake(){
		damageTable = new Dictionary<string, float>();
		defenseTable = new Dictionary<string, float>();
		damageTable.Add("B",1);
		damageTable.Add("P",1);
		damageTable.Add("S",1);
		damageTable.Add ("RB",1);
		damageTable.Add("RP",1);
		damageTable.Add("RS",1);
		damageTable.Add("E",1);
		damageTable.Add("N",1);
		damageTable.Add("C",1);
		damageTable.Add("F",1);
		damageTable.Add("PO",1);
		damageTable.Add("PS",1);
		damageTable.Add("L",1);
		damageTable.Add("I",1);
		defenseTable.Add("B",1);
		defenseTable.Add("P",1);
		defenseTable.Add("S",1);
		defenseTable.Add ("RB",1);
		defenseTable.Add("RP",1);
		defenseTable.Add("RS",1);
		defenseTable.Add("E",1);
		defenseTable.Add("N",1);
		defenseTable.Add("C",1);
		defenseTable.Add("F",1);
		defenseTable.Add("PO",1);
		defenseTable.Add("PS",1);
		defenseTable.Add("L",1);
		defenseTable.Add("I",1);
	}


	public float getTreeDamage(TreeType type){
	switch(type){
	case TreeType.PHYSICAL:
		return this.getPhysical();
	case TreeType.MAGICAL:
		return this.getMagical();
	default :
			Debug.Log("Something's wrong here!");
			return 0;
	}}

	public float getDamageTypeDamage(DamageType type){
		switch(type){
		case DamageType.CHAOS:
			return this.getChaos();
		case DamageType.ELEMENTAL:
			return this.getElemental();
		case DamageType.NATURAL:
			return this.getNatural();
		case DamageType.MELEE:
			return this.getMelee();
		case DamageType.RANGED:
			return this.getRanged();
		default : Debug.Log("Something's wrong here!");
			return 0;
	}
	}

	public float getSpecialDamage(SpecialType type){
		switch(type){
		case SpecialType.BLUNT:
			return this.getBlunt();
		case SpecialType.BURN:
			return this.getBurn();
		case SpecialType.ICE:
			return this.getIce();
		case SpecialType.PIERCING:
			return this.getPiercing();
		case SpecialType.POISON:
			return this.getPoison();
		case SpecialType.PSYCHIC:
			return this.getPsychic();
		case SpecialType.SLASHING:
			return this.getSlashing();
		case SpecialType.SURGE:
			return this.getSurge();
		
		default : Debug.Log("Something's wrong here!");
		return 0;
	}
	}

	public int getHealth(){
		return health;
	}
	public void setHealth(int health){
		this.health = health;
	}
	//getters and setters
	public float getDamage(){
		return damage;
	}
	public void setDamage(float damage){
		this.damage = damage;
	}

	public float getPhysical(){
		return physical;
	}
	public void setPhysical(float physical){
		this.physical = physical;
	}

	public float getMelee(){
		return melee;
	}
	public void setMelee(float melee){
		this.melee = melee;
	}

	public float getRanged(){
		return ranged;
	}
	public void setRanged(float ranged){
		this.ranged = ranged;
	}

	public float getMagical(){
		return magical;
	}
	public void setMagical(float magical){
		this.magical = magical;
	}

	public float getChaos(){
		return chaos;
	}
	public void setChaos(float chaos){
		this.chaos = chaos;
	}

	public float getElemental(){
		return elemental;
	}
	public void setElemental(float elemental){
		this.elemental = elemental;
	}

	public float getNatural(){
		return natural;
	}
	public void setNatural(float natural){
		this.natural = natural;
	}

	public float getSpecial(){
		return this.special;
	}
	public void setSpecial(float special){
		this.special = special;
	}

	public float getBurn(){
		return burn;
	} 
	public void setBurn(float burn){
		this.burn = burn;
	}

	public float getPoison(){
		return poison;
	}
	public void setPoison(float poison){
		this.poison = poison;
	}

	public float getPsychic(){
		return psychic;
	}
	public void setPsychic(float psychic){
		this.psychic = psychic;
	}

	public float getSurge(){
		return surge;
	}
	public void setSurge(float surge){
		this.surge = surge;
	}

	public float getIce(){
		return ice;
	}
	public void setIce(float ice){
		this.ice = ice;
	}

	public float getBlunt(){
		return blunt;
	}
	public void setBlunt(float blunt){
		this.blunt=blunt;
	}

	public float getPiercing(){
		return piercing;
	}
	public void setPiercing(float piercing){
		this.piercing = piercing;
	}

	public float getSlashing(){
		return slashing;
	}
	public void setSlashing(float slashing){
		this.slashing = slashing;
	}

	public float getDamageR(){
		return damageResist;
	}
	public void setDamageR(float damageResist){
		this.damageResist = damageResist;
	}
	
	public float getPhysicalR(){
		return physicalResist;
	}
	public void setPhysicalR(float physicalResist){
		this.physicalResist = physicalResist;
	}
	
	public float getMeleeR(){
		return meleeResist;
	}
	public void setMeleeR(float meleeResist){
		this.meleeResist = meleeResist;
	}
	
	public float getRangedR(){
		return rangedResist;
	}
	public void setRangedR(float rangedResist){
		this.rangedResist = rangedResist;
	}
	
	public float getMagicalR(){
		return magicalResist;
	}
	public void setMagicalR(float magicalResist){
		this.magicalResist = magicalResist;
	}
	
	public float getChaosR(){
		return chaosResist;
	}
	public void setChaosR(float chaosResist){
		this.chaosResist = chaosResist;
	}
	
	public float getElementalR(){
		return elementalResist;
	}
	public void setElementalR(float elementalResist){
		this.elementalResist = elementalResist;
	}
	
	public float getNaturalR(){
		return naturalResist;
	}
	public void setNaturalR(float naturalResist){
		this.naturalResist = naturalResist;
	}
	
	public float getBurnR(){
		return burnResist;
	} 
	public void setBurnR(float burnResist){
		this.burnResist = burnResist;
	}
	
	public float getPoisonR(){
		return poisonResist;
	}
	public void setPoisonR(float poisonResist){
		this.poisonResist = poisonResist;
	}
	
	public float getPsychicR(){
		return psychicResist;
	}
	public void setPsychicR(float psychicResist){
		this.psychicResist = psychicResist;
	}
	
	public float getSurgeR(){
		return surgeResist;
	}
	public void setSurgeR(float surgeResist){
		this.surgeResist = surgeResist;
	}
	
	public float getIceR(){
		return iceResist;
	}
	public void setIceR(float iceResist){
		this.iceResist = iceResist;
	}
	
	public float getBluntR(){
		return bluntResist;
	}
	public void setBluntR(float bluntResist){
		this.bluntResist = bluntResist;
	}
	
	public float getPiercingR(){
		return piercingResist;
	}
	public void setPiercingR(float piercingResist){
		this.piercingResist = piercingResist;
	}
	
	public float getSlashingR(){
		return slashingResist;
	}
	public void setSlashingR(float slashingResist){
		this.slashingResist = slashingResist;
	}

	public float getVitality(){
		return vitality;
	}
	public void setVitality(float vitality){
		this.vitality = vitality;
	}

	public float getSpeed(){
		return speed;
	}
	public void setSpeed(float speed){
		this.speed = speed;
	}
}




























