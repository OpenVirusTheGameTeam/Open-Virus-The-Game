using UnityEngine;
using System.Collections;

public class GameStarter : MonoBehaviour {

    public GameObject pilotPrefab;
    public GameObject navSystemPrefab;

	void Awake () {
        GameObject.Instantiate(pilotPrefab, new Vector3(0, 20, 0), Quaternion.identity);
        GameObject.Instantiate(navSystemPrefab, Vector3.zero, Quaternion.identity);
	}
	
	void Update () {
	
	}
}
