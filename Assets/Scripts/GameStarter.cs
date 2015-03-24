using UnityEngine;
using System.Collections;

public class GameStarter : MonoBehaviour {

    public GameObject pilotPrefab;
    public GameObject navSystemPrefab;

	void Awake () {
        
		GameObject.Instantiate(pilotPrefab, transform.position, Quaternion.identity); //Thought it would be easier if the player spawned wherever this object was
        GameObject.Instantiate(navSystemPrefab, Vector3.zero, Quaternion.identity);

	}
	
	void Update () {
	
	}
}
