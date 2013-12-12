using UnityEngine;
using System.Collections;

public class TransformFacePlayer : MonoBehaviour
{
		public int distanceApart;

		void Start ()
		{
	
		}

		void Update ()
		{
				if (Vector3.Distance (this.gameObject.transform.position, GameObject.Find ("Player").transform.position) < 10) {
						GameObject thisThing = this.gameObject;
						Transform thisTransform = thisThing.transform;
						Transform cameraTransform = GameObject.Find ("MainCameraPlane/Main Camera").transform;
						thisTransform.LookAt (cameraTransform);
						thisTransform.eulerAngles = new Vector3 (0f, thisTransform.eulerAngles.y, thisTransform.eulerAngles.z);
						//thisTransform = eulerAngles(thisTranform,0f,thisTranform);
				}
		}
}
