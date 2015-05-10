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

	bool MainMenuVisible;
	bool MultiplayerMenuVisible;
	bool ServerMenuVisible;
	bool ClientMenuVisible;

	string ServerPort = "";
	string ServerMaxplayers = "";
	string ServerName = "";
	string ServerDesc = "";

	bool ServerReg = false;

	string ClientPort = "";
	string ClientIP = "";

	// Use this for initialization
	void Start () {

		MainMenuVisible = true;

	}

	void Update () {

		centerWindowWidth = (Screen.width / 2) - (mainWinWidth / 2);
		centerWindowHeight = (Screen.height / 2) - (mainWinHeight / 2);

		centerScreenWidth = (Screen.width / 2);
		centerScreenHeight = (Screen.height / 2);

	}

	void OnGUI(){

		if(MainMenuVisible){

		GUI.skin = menuSkin;

		GUI.Box (new Rect(centerWindowWidth, centerWindowHeight, mainWinWidth, mainWinHeight), "Main Menu");

		if (GUI.Button (new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 30 + buttonHeight, buttonWidth, buttonHeight), "Play Mission...")) {



		}

		if (GUI.Button (new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 90 + buttonHeight, buttonWidth, buttonHeight), "Multiplayer...")) {
			
			MainMenuVisible = false;
			MultiplayerMenuVisible = true;
			
		}
		
		}

		Multiplayer();
		Server();
		Client ();

	}

	void MissionSelect(){



	}

	void Multiplayer(){

		if(MultiplayerMenuVisible){

		GUI.skin = menuSkin;

		GUI.Box (new Rect(centerWindowWidth, centerWindowHeight, mainWinWidth, mainWinHeight), "Multiplayer");

		if (GUI.Button (new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 30 + buttonHeight, buttonWidth, buttonHeight), "Server")) {
			
				MultiplayerMenuVisible = false;
				ServerMenuVisible = true;
			
		}

		if (GUI.Button (new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 90 + buttonHeight, buttonWidth, buttonHeight), "Client")) {
				
			MultiplayerMenuVisible = false;
			ClientMenuVisible = true;
				
		}
	
		}

	}

	void Server(){

		GUI.skin = menuSkin;

		if(ServerMenuVisible){

			GUI.Box (new Rect(centerWindowWidth, centerWindowHeight, mainWinWidth, mainWinHeight), "Server");
				
			ServerPort = GUI.TextField(new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 30 + buttonHeight, buttonWidth, 20), ServerPort, 5);
			ServerMaxplayers = GUI.TextField(new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 70 + buttonHeight, buttonWidth, 20), ServerMaxplayers, 2);
			ServerName = GUI.TextField(new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 110 + buttonHeight, buttonWidth, 20), ServerName, 32);
			ServerDesc = GUI.TextField(new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 150 + buttonHeight, buttonWidth, 20), ServerDesc, 64);
			ServerReg = GUI.Toggle(new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 190 + buttonHeight, buttonWidth, 20), ServerReg, "Register With Master Server");

				if (GUI.Button (new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 230 + buttonHeight, buttonWidth, buttonHeight), "Start")) {

				VarPool.pushInt("SERVER_PORT", int.Parse(ServerPort));
				VarPool.pushInt("SERVER_MAXPLAYERS", int.Parse(ServerMaxplayers));
				VarPool.pushString("SERVER_NAME", ServerName);
				VarPool.pushString("SERVER_DESCRIPTION", ServerDesc);
				VarPool.pushBool("SERVER_REGISTERED", ServerReg);

				Application.LoadLevel("Server");
				
				}

		}

	}

	void Client(){

		GUI.skin = menuSkin;

		if(ClientMenuVisible){
		
			GUI.Box (new Rect(centerWindowWidth, centerWindowHeight, mainWinWidth, mainWinHeight), "Client");

			ClientIP = GUI.TextField(new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 30 + buttonHeight, buttonWidth, 20), ClientIP, 11);
			ClientPort = GUI.TextField(new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 70 + buttonHeight, buttonWidth, 20), ClientPort, 5);

			if (GUI.Button (new Rect (centerScreenWidth - (buttonWidth / 2), centerWindowHeight + 110 + buttonHeight, buttonWidth, buttonHeight), "Connect")) {
				
				VarPool.pushInt("CLIENT_PORT", int.Parse(ClientPort));
				VarPool.pushString("CLIENT_IP", ClientIP);
				
				Application.LoadLevel("Client");
				
			}	
		
		}
	}
}
