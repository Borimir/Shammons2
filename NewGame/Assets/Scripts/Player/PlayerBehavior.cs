using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{	
		public float basePlayerSpeed;
		public float sprintMultiplier;
		private float playerSpeed;
		private float xScale;
		private Animator anim;

		// Use this for initialization
		void Start ()
		{
				xScale = transform.localScale.x; //Get correct starting Orientation for player.
				anim = (Animator)gameObject.GetComponent ("Animator"); //Get Animations for character
				Debug.Log (xScale);
		}
	
		// Update is called once per frame
		void Update ()
		{
				GameObject player = GameObject.Find ("Player");
				Vector3 playerPos = player.transform.position;
				if (Input.GetKey (KeyCode.LeftShift)) {
						playerSpeed = basePlayerSpeed * sprintMultiplier;
				} else
						playerSpeed = basePlayerSpeed;
				if (Input.GetButton ("Horizontal")) {
						float amountToMove = Input.GetAxisRaw ("Horizontal") * playerSpeed * Time.deltaTime;
						transform.Translate (Vector3.right * amountToMove);

						if (amountToMove < 0) {
								transform.localScale.Set (xScale, transform.localScale.y, transform.localScale.z);
								Debug.Log (transform.localScale.x);
						} else if (amountToMove > 0) {
								transform.localScale.Set (-1 * (xScale), transform.localScale.y, transform.localScale.z);
								Debug.Log (transform.localScale.x);

						}
						anim.SetBool ("isMoving", true); //Animate
				}
		
				if (Input.GetButton ("Vertical")) {
						float amountToMoveUp = Input.GetAxisRaw ("Vertical") * playerSpeed * Time.deltaTime;
						transform.Translate (Vector3.forward * amountToMoveUp);
						anim.SetBool ("isMoving", true); //Animate
				}
				if (!Input.GetButton ("Vertical") && !Input.GetButton ("Horizontal")) {
						anim.SetBool ("isMoving", false);		
				}
		}
}
