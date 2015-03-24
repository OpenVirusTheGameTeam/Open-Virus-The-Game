using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	private bool openDoor;
	private float startingDoorPos;
	private bool closeActivated;
	private GameObject doorObject;

	void Start () {

		doorObject = this.transform.parent.gameObject;
		startingDoorPos = transform.position.y;

	}

	void FixedUpdate () {
	
		if (openDoor && transform.position.y < (startingDoorPos + 8.5f)) {

				doorObject.transform.position = new Vector3(doorObject.transform.position.x, doorObject.transform.position.y + 0.1f, doorObject.transform.position.z);

		} else if (!openDoor && transform.position.y > startingDoorPos) {

			doorObject.transform.position = new Vector3(doorObject.transform.position.x, doorObject.transform.position.y - 0.1f, doorObject.transform.position.z);

		}

		if (!closeActivated && transform.position.y >= (startingDoorPos + 8.5f)) {

			closeActivated = true;
			StartCoroutine("StartDoorCloseTimer");

		}

	}

	void OnTriggerEnter(Collider col) {

		openDoor = true;

	}

	IEnumerator StartDoorCloseTimer() {

		yield return new WaitForSeconds(3);
		openDoor = false;
		closeActivated = false;

	}

}
