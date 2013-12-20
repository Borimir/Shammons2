using UnityEngine;
using System.Collections;

public class PlayerGUI : MonoBehaviour
{
	
		public Texture bloodscreen;

		void OnGUI ()
		{	
				//font size
				int fontSize = 20;

				GUIStyle style = new GUIStyle ();
				style.fontSize = fontSize;
				GUI.skin.label.alignment = TextAnchor.MiddleCenter;

			

				//x center of this component of the GUI
				int x = 0;
				//y center of this component of the GUI
				int y = 0;
				//the width of the component
				int componentWidth = 100;
				//the height of the component
				int componentHeight = 100;
				//draw the background image
				GUI.DrawTexture (new Rect (x, y, componentWidth, componentHeight), bloodscreen, ScaleMode.ScaleToFit);
				//draw the players health on top of the background image
				GUI.Label (new Rect (x +(componentWidth/ 2),y+( componentHeight/2 - fontSize / 2), componentWidth / 2, componentHeight / 2), ((PlayerStats)(GameObject.Find ("Player").GetComponent ("PlayerStats"))).getHealth ().ToString (), style);

		}

}
