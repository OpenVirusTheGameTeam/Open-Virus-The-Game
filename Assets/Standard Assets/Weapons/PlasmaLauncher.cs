using UnityEngine;
using System.Collections;

public class PlasmaLauncher : MonoBehaviour {

	public GameObject plasmaBall;
	public Camera shipCam;

	RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
	
		if(Input.GetMouseButtonDown(0)){

			Ray ray = shipCam.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0)); 

			if(Physics.Raycast(ray, out hit, Mathf.Infinity)){

				GameObject particleTemp = (GameObject)Network.Instantiate(plasmaBall, this.transform.position, Quaternion.identity, 0);
				particleTemp.transform.LookAt(hit.point);

			}
			
		}

	}
}
