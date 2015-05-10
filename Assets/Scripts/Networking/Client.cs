using UnityEngine;
using System.Collections;

public class Client : MonoBehaviour {

	public Vector3 spawnPoint;
	public GameObject playerPrefab;

	void Awake(){

		Debug.Log("Connecting to " + VarPool.popString("CLIENT_IP") + " on port " + VarPool.popInt("CLIENT_PORT") + "...");
		Network.Connect(VarPool.popString("CLIENT_IP"), VarPool.popInt("CLIENT_PORT"));

	}

	void OnConnectedToServer(){

		Debug.Log ("Connection Successful!");

		GameObject tempPlayer = (GameObject)Network.Instantiate(playerPrefab, spawnPoint, Quaternion.identity, 0);

	}

}
