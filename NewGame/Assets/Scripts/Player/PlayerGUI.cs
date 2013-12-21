using UnityEngine;
using System.Collections;

public class PlayerGUI : MonoBehaviour
{
		//x center of this component of the GUI
		public int healthX = 0;
		//y center of this component of the GUI
		public int healthY = 0;
		//the width of the component
		public int healthComponentWidth = 100;
		//the height of the component
		public int healthComponentHeight = 100;

		//x center of the minimap
		public int miniMapX = 0;
		//y center of the minimap
		public int miniMapY = 0;
		// width of the miniMap frame
		public int miniMapComponentWidth = 100;
		//the height of the miniMap frame
		public int miniMapComponentHeight = 100;

	//x center of the skillbar
	public int skillbarX = 0;
	//y center of the skillbar
	public int skillbarY = 0;
	//width of skillbar component
	public int skillbarComponentWidth = 100;
	//height of skillbar component
	public int skillbarComponentHeight = 100;

		//the healthbar image
		public Texture healthbar;
		//the minimap frame image
		public Texture minimap;
	//the skillbar image
		public Texture skillbar;

	void Start(){
		skillbarX = Screen.width/2;
		skillbarComponentWidth = Screen.width; 
		skillbarComponentHeight = Screen.height;
		skillbarY = Screen.height-64;
	}
		void OnGUI ()
		{	
				//font size
				int fontSize = 15;

				GUIStyle style = GUI.skin.GetStyle ("Label");
				style.fontSize = fontSize;
				style.alignment = TextAnchor.MiddleCenter;

			


				
				
				//draw the background image
				GUI.DrawTexture (new Rect (healthX - healthComponentWidth / 2, healthY - healthComponentHeight / 2, healthComponentWidth, healthComponentHeight), healthbar, ScaleMode.ScaleToFit);
				//draw the players health on top of the background image
				GUI.Label (new Rect (healthX - healthComponentWidth / 2, healthY - healthComponentHeight / 2, healthComponentWidth, healthComponentHeight), ((PlayerStats)(GameObject.Find ("Player").GetComponent ("PlayerStats"))).getHealth ().ToString (), style);
				//draw minimap
				GUI.DrawTexture (new Rect (miniMapX - miniMapComponentWidth / 2, miniMapY - miniMapComponentHeight / 2, miniMapComponentWidth, miniMapComponentHeight), minimap, ScaleMode.ScaleToFit);
		//draw skillbar
		GUI.DrawTexture (new Rect (skillbarX - skillbarComponentWidth / 2, skillbarY - skillbarComponentHeight / 2, skillbarComponentWidth, skillbarComponentHeight), skillbar, ScaleMode.ScaleToFit);		}

}
