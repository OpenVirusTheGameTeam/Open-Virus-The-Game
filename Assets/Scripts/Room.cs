using UnityEngine;
using System.Collections;

public class Room : MonoBehaviour {

	public string dirName;

	void OnTriggerEnter(Collider col) {
		
		if (col.gameObject.GetComponent<NavigationSystem> () != null) {

			col.gameObject.GetComponent<NavigationSystem>().SetDir(dirName);

		}
		
	}
}
