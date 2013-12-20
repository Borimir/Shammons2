using UnityEngine;
using System;
using System.Collections.Generic;

public class SpikeTrap : MonoBehaviour
{
	

		private GameObject player;
		private AttackPacket proxAttackPacket;
		private float countdown;

		void Awake ()
		{
		countdown = 5;
		}

		void Start ()
		{
				player = GameObject.Find ("Player");
				List<DamagePacket> damageList = new List<DamagePacket> ();
				damageList.Add (new DamagePacket ("RP", 10));
				proxAttackPacket = new AttackPacket (damageList);
		}
	
		public void updateCountdown ()
		{
				
				countdown = countdown - Time.deltaTime;
		}

		public void resetCountdown ()
		{
				countdown = 5;
		}

		void FixedUpdate ()
		{

				if (Vector3.Distance (player.transform.position, this.gameObject.transform.position) < 10) {
						updateCountdown ();

						if (countdown <= 0) {
								player.SendMessage ("handleAttackPacket", proxAttackPacket);
				resetCountdown();
						}
				} else {
						resetCountdown ();
				}
		}
		
}

