using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Server : MonoBehaviour {

	// Server for OSVTG

	private int Port;
	private int MaxPlayers;
	private bool Registered;
	private string ServerName;
	private string ServerDesc;

	public GameObject Lobby;
	public GameObject PlayerPrefab;

	List<NetworkPlayer> playerList = new List<NetworkPlayer>();

	void Awake () {

		Debug.Log("========== OSVTG SERVER STARTED ==========");

		Debug.Log("IP: " + Network.player.ipAddress);

		Port = VarPool.popInt("SERVER_PORT");
		Debug.Log("Port: " + Port);

		MaxPlayers = VarPool.popInt("SERVER_MAXPLAYERS");
		Debug.Log("Max Players: " + MaxPlayers);

		Registered = VarPool.popBool("SERVER_REGISTERED");
		Debug.Log("Registered: " + Registered);

		ServerName = VarPool.popString("SERVER_NAME");
		Debug.Log("Name: " + ServerName);

		ServerDesc = VarPool.popString("SERVER_DESCRIPTION");
		Debug.Log("Description: " + ServerDesc);

		StartServer();

		Debug.Log("==========================================\n");

	}

	void StartServer(){

		bool UseNAT = !Network.HavePublicAddress();
		Debug.Log("NAT Punchthrough: " + UseNAT);

		Network.InitializeServer(MaxPlayers, Port, UseNAT);
		Debug.Log("Server Initialized Sucessfully");

		if(Registered){

			MasterServer.RegisterHost("VTGTEAM_OSVTG", ServerName, ServerDesc);
			Debug.Log("Server Registered With Master Server Sucessfully");

		}

	}

	void OnServerInitialized(){

		GameObject lobbyObj = (GameObject)Network.Instantiate(Lobby, Vector3.zero, Quaternion.identity, 0);
		GameObject tempPlayer = (GameObject)Network.Instantiate(PlayerPrefab, new Vector3(0, 21, 0), Quaternion.identity, 0);

		Debug.Log("Server Initialized Sucessfully");

	}

	private void OnPlayerConnected(NetworkPlayer player){

		Debug.Log("Player " + player.ToString() + " has joined the server.");
		playerList.Add(player);

	}

	public string[] getPlayerList(){

		string[] tempSArray = new string[playerList.Count];
		int I = 0;

		foreach (NetworkPlayer p in playerList){

			tempSArray[I] = p.ToString();
			I++;

		}

		return tempSArray;

	}
	
}
