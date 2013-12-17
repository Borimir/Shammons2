using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	//damage stats
	//factor damage
	public int damage,physical,melee,ranged,magical,chaos,elemental,natural;
	//special damage
	public int burn,poison,psychic,surge,blunt,piercing,slashing;

	//defensive stats
	//factor defense
	public int defense,armor,meleeResist,rangedResist,magicResist,chaosResist,elementalResist,naturalResist;
    
	//special resistance
	public int burnResist,poisonResist,psychicResist,surgeResist,bluntResist,piercingResist,slashingResist;

	//other personal enhancements
	public int vitality,speed;
}
