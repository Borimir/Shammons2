using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour
{
		public float panSensitivity = 5;
		public float zoomSensitivity;
		public int margin;
		public float heightAbove;
		public int minHeight;
		public float distanceBehind;
		public int minBehind;
		public float rightOffset;
		public int rotateSensitivity;
		public bool lookAtPlayer;
		GameObject player;
		Vector3 playerPos;
		GameObject camera;
		Transform cameraPos;
		Vector3 mousePos;
		Transform gameTransform;

		void Awake ()
		{
				camera = GameObject.Find ("Main Camera");
				player = GameObject.Find ("Player");
				playerPos = player.transform.position;
				cameraPos = camera.transform;
				gameTransform = this.gameObject.transform;
				this.gameObject.transform.eulerAngles = new Vector3 (0f, 0f, 0f);
				//this.gameObject.transform.position = new Vector3 (playerPos.x + rightOffset, playerPos.y + heightAbove, playerPos.z - distanceBehind);
				cameraPos.position = new Vector3 (playerPos.x + rightOffset, playerPos.y + heightAbove, playerPos.z + distanceBehind);
				cameraPos.LookAt (player.transform);
		}
	
		void Update ()
		{
				playerPos = player.transform.position;

				//pan camera
				moveCamWithPlayer ();
				//rotate camera
				rotateCamera ();
				//zoom camera
				float deltaWheel = Input.GetAxis ("Mouse ScrollWheel");
				if (deltaWheel != 0) {
						camLockedZoom (deltaWheel, camera);
				}
				if (lookAtPlayer) {
						cameraPos.LookAt (player.transform);
				}
		}
	
		void moveCamWithPlayer ()
		{
				if (Input.GetButton ("Horizontal") || Input.GetButton ("Vertical")) {
						cameraPos.position = new Vector3 (playerPos.x + rightOffset, playerPos.y + heightAbove, playerPos.z + distanceBehind);
				}
				
		}
	
		void rotateCamera ()
		{
				Vector3 mousePos = Input.mousePosition;
				if (mousePos.x >= Screen.width - margin) {
						gameTransform.RotateAround (playerPos, Vector3.down, rotateSensitivity * Time.deltaTime);
						rightOffset = cameraPos.position.x - playerPos.x;
						heightAbove = cameraPos.position.y - playerPos.y;
						distanceBehind = -(cameraPos.position.z - playerPos.z);
				} else if (mousePos.x <= margin) {
						gameTransform.RotateAround (playerPos, Vector3.up, rotateSensitivity * Time.deltaTime);
						rightOffset = cameraPos.position.x - playerPos.x;
						heightAbove = cameraPos.position.y - playerPos.y;
						distanceBehind = -(cameraPos.position.z - playerPos.z);
				}  
		}
	
		void camLockedZoom (float deltaWheel, GameObject camera)
		{
				float newHeightAbove = heightAbove - (deltaWheel * zoomSensitivity);
				float newDistanceBehind = distanceBehind - (deltaWheel * zoomSensitivity);
				if (newHeightAbove >= minHeight)
						heightAbove = newHeightAbove;
				if (newDistanceBehind >= minBehind)
						distanceBehind = newDistanceBehind;
				Transform cameraPos = camera.transform;
				cameraPos.position = new Vector3 (playerPos.x + rightOffset, playerPos.y + heightAbove, playerPos.z + distanceBehind);
		}
}
