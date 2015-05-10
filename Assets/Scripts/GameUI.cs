using UnityEngine;
using System.Collections;

public class GameUI : MonoBehaviour {

	NetworkView myNV;
	string[] players = new string[Network.maxConnections];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		if(Input.GetKeyDown(KeyCode.Tab)){

			GUI.Box (new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200), "");

		}

	}

	[RPC]
	public void updatePlayerList(string[] updatedList){

		int I = 0;

		foreach(string s in updatedList){

			players[I] = s;
			I++;

		}

	}
}
