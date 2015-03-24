using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GUISkin menuSkin;

	public float mainWinWidth;
	public float mainWinHeight;

	public float buttonWidth;
	public float buttonHeight;

	float centerWindowWidth;
	float centerWindowHeight;
	
	float centerScreenWidth;
	float centerScreenHeight;

	// Use this for initialization
	void Start () {
	
	}

	void Update () {

		centerWindowWidth = (Screen.width / 2) - (mainWinWidth / 2);
		centerWindowHeight = (Screen.height / 2) - (mainWinHeight / 2);

		centerScreenWidth = (Screen.width / 2);
		centerScreenHeight = (Screen.height / 2);

	}

	void OnGUI(){

		GUI.skin = menuSkin;

		GUI.Box (new Rect(centerWindowWidth, centerWindowHeight, mainWinWidth, mainWinHeight), "Main Menu");

		if (GUI.Button (new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 30 + buttonHeight, buttonWidth, buttonHeight), "Play Mission...")) {



		}

	}

	void MissionSelect(){



	}
}
