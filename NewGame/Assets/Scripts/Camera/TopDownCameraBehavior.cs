using UnityEngine;
using System.Collections;

public class TopDownCameraBehavior : MonoBehaviour
{
		public float panSensitivity;
		public float zoomSensitivity;
		public int margin;
		public int heightAbove;
		public int minHeight;
		public int distanceBehind;
		public int minBehind;
		public int rotateSensitivity;
		public bool cameraLock;
		public bool lookAtPlayer;

		void Awake ()
		{
				GameObject player = GameObject.Find ("Player");
				Vector3 playerPos = player.transform.position;

				this.gameObject.transform.eulerAngles = new Vector3 (0f, 0f, 0f);
				this.gameObject.transform.position = new Vector3 (playerPos.x, playerPos.y + heightAbove, playerPos.z - distanceBehind);

				GameObject camera = GameObject.Find ("MainCameraPlane/Main Camera");
				Transform cameraPos = camera.transform;

				cameraPos.position = new Vector3 (playerPos.x, playerPos.y + heightAbove, playerPos.z - distanceBehind);

				cameraPos.LookAt (player.transform);


		}

		void Update ()
		{
				//pan camera
				if (cameraLock)
						moveCamWithPlayer ();
				//else if (!cameraLock)
				//		camUnlockedPan ();

				//rotate camera
				rotateCamera ();

				//zoom camera
				float deltaWheel = Input.GetAxis ("Mouse ScrollWheel");
				GameObject camera = GameObject.Find ("MainCameraPlane/Main Camera");

				if (deltaWheel != 0) {
						if (cameraLock)
								camLockedZoom (deltaWheel, camera);
						else if (!cameraLock)
								camUnlockedZoom (deltaWheel, camera);
				}
				if (lookAtPlayer) {
						Transform cameraPos = camera.transform;
						GameObject player = GameObject.Find ("Player");
						cameraPos.LookAt (player.transform);
				}

		}

		void moveCamWithPlayer ()
		{
				if (Input.GetButton ("Horizontal") || Input.GetButton ("Vertical")) {
						GameObject player = GameObject.Find ("Player");
						Vector3 playerPos = player.transform.position;
						GameObject camera = GameObject.Find ("MainCameraPlane/Main Camera");
						Transform cameraPos = camera.transform;
						cameraPos.position = new Vector3 (playerPos.x, playerPos.y + heightAbove, playerPos.z - distanceBehind);
				}
		}

		void camUnlockedPan ()
		{
				Vector3 mousePos = Input.mousePosition;
				Transform gameTransform = this.gameObject.transform;
		
		
				if (mousePos.x >= Screen.width - margin && mousePos.y >= Screen.height - margin) {
						gameTransform.Translate (new Vector3 (panSensitivity, 0f, panSensitivity));
				} else if (mousePos.x <= margin && mousePos.y <= margin) {
						gameTransform.Translate (new Vector3 (-panSensitivity, 0f, -panSensitivity));	
				} else if (mousePos.x <= margin && mousePos.y >= Screen.height - margin) {
						gameTransform.Translate (new Vector3 (-panSensitivity, 0f, panSensitivity));	
				} else if (mousePos.x >= Screen.width - margin && mousePos.y <= margin) {
						gameTransform.Translate (new Vector3 (panSensitivity, 0f, -panSensitivity));
				} else if (mousePos.x >= Screen.width - margin) {
						gameTransform.Translate (new Vector3 (panSensitivity, 0f, 0f));
				} else if (mousePos.x <= margin) {
						gameTransform.Translate (new Vector3 (-panSensitivity, 0f, 0f));
				} else if (mousePos.y >= Screen.height - margin) {
						gameTransform.Translate (new Vector3 (0f, 0f, panSensitivity));
				} else if (mousePos.y <= margin) {
						gameTransform.Translate (new Vector3 (0f, 0f, -panSensitivity));
				} 
		}

		void rotateCamera ()
		{
				Vector3 mousePos = Input.mousePosition;

				Transform gameTransform = this.gameObject.transform;
				GameObject player = GameObject.Find ("Player");
				Vector3 playerPos = player.transform.position;
				if (Input.GetKey (KeyCode.Q)) {
						gameTransform.RotateAround (playerPos, Vector3.up, rotateSensitivity * Time.deltaTime);
				} else if (Input.GetKey (KeyCode.E)) {
						gameTransform.RotateAround (playerPos, Vector3.down, rotateSensitivity * Time.deltaTime);
				} else if (mousePos.x >= Screen.width - margin) {
						gameTransform.RotateAround (playerPos, Vector3.down, rotateSensitivity * Time.deltaTime);
				} else if (mousePos.x <= margin) {
						gameTransform.RotateAround (playerPos, Vector3.up, rotateSensitivity * Time.deltaTime);
				} 
//		else if (mousePos.y >= Screen.height - margin) {
//						gameTransform.RotateAround (playerPos, Vector3.right, rotateSensitivity * Time.deltaTime);
//				} else if (mousePos.y <= margin) {
//						gameTransform.RotateAround (playerPos, Vector3.left, rotateSensitivity * Time.deltaTime);
//				} 
		}

		void camLockedZoom (float deltaWheel, GameObject camera)
		{
				GameObject player = GameObject.Find ("Player");
				Vector3 playerPos = player.transform.position;
				int newHeightAbove = heightAbove - (int)(deltaWheel * zoomSensitivity);
				int newDistanceBehind = distanceBehind - (int)(deltaWheel * zoomSensitivity);
				if (newHeightAbove >= minHeight)
						heightAbove = newHeightAbove;
				if (newDistanceBehind >= minBehind)
						distanceBehind = newDistanceBehind;
				Transform cameraPos = camera.transform;
				cameraPos.position = new Vector3 (playerPos.x, playerPos.y + heightAbove, playerPos.z - distanceBehind);
		}

		void camUnlockedZoom (float deltaWheel, GameObject camera)
		{
				GameObject player = GameObject.Find ("Player");
				Vector3 playerPos = player.transform.position;
				int newHeightAbove = heightAbove - (int)(deltaWheel * zoomSensitivity);
				if (newHeightAbove >= minHeight)
						heightAbove = newHeightAbove;
				Transform cameraPos = camera.transform;
				cameraPos.position = new Vector3 (cameraPos.position.x, playerPos.y + heightAbove, cameraPos.position.z);
		}
	
}
