using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{	
		public float basePlayerSpeed;
		public float sprintMultiplier;
		private float playerSpeed;
		private float xScale;
		private Animator anim;
		private GameObject playerCam;

		// Use this for initialization
		void Start ()
		{
				xScale = transform.localScale.x; //Get correct starting Orientation for player.
				anim = (Animator)gameObject.GetComponent ("Animator"); //Get Animations for character
				Debug.Log (xScale);
				playerCam = GameObject.Find ("Main Camera");
		}
	
		// Update is called once per frame
		void Update ()
		{
				Transform cameraTrans = playerCam.transform;
				GameObject player = GameObject.Find ("Player");
				Vector3 playerPos = player.transform.position;
				if (Input.GetKey (KeyCode.LeftShift)) {
						playerSpeed = basePlayerSpeed * sprintMultiplier;
				} else
						playerSpeed = basePlayerSpeed;
				if (Input.GetButton ("Horizontal")) {
						Vector3 cameraRight = cameraTrans.right;
						Vector3 direction = new Vector3 (cameraRight.x, 0, cameraRight.z);

						float amountToMove = Input.GetAxisRaw ("Horizontal") * playerSpeed * Time.deltaTime;
						transform.Translate (direction * amountToMove);

						if (amountToMove < 0) {
								//transform.localScale.Set (xScale, transform.localScale.y, transform.localScale.z);
								Debug.Log (transform.localScale.x);
						} else if (amountToMove > 0) {
								//transform.localScale.Set (-1 * (xScale), transform.localScale.y, transform.localScale.z);
								Debug.Log (transform.localScale.x);

						}
						anim.SetBool ("isMoving", true); //Animate
				}
		
				if (Input.GetButton ("Vertical")) {
						Vector3 cameraForward = cameraTrans.forward;
						Vector3 direction = new Vector3 (cameraForward.x, 0, cameraForward.z);

						float amountToMoveUp = Input.GetAxisRaw ("Vertical") * playerSpeed * Time.deltaTime;
						transform.Translate (direction * amountToMoveUp);

						anim.SetBool ("isMoving", true); //Animate
				}

				if (!Input.GetButton ("Vertical") && !Input.GetButton ("Horizontal")) {
						anim.SetBool ("isMoving", false);		
				}
		}

	public void handleAttackPacket(AttackPacket packet){
		Debug.Log("OUCH");
	}
}
