using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{
	public float playerSpeed;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				GameObject player = GameObject.Find ("Player");
				Vector3 playerPos = player.transform.position;
				if (Input.GetButton ("Horizontal")) {
						float amountToMove = Input.GetAxisRaw ("Horizontal") * playerSpeed * Time.deltaTime;
						transform.Translate (Vector3.right * amountToMove);
				}
		
				if (Input.GetButton ("Vertical")) {
						float amountToMoveUp = Input.GetAxisRaw ("Vertical") * playerSpeed * Time.deltaTime;
						transform.Translate (Vector3.forward * amountToMoveUp);
				}
		}
}
