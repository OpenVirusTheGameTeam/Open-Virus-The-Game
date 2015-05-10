using UnityEngine;
using System.Collections;

public class NetBridge : MonoBehaviour {

	[RPC]
	public string[] getPlayers(){

		if(GameObject.FindGameObjectWithTag("SERVER_OBJ") != null){

			GameObject tempServer = GameObject.FindGameObjectWithTag("SERVER_OBJ");
			Server serverObj = tempServer.GetComponent<Server>();
			return serverObj.getPlayerList();

		} else {

			return null;

		}

	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
