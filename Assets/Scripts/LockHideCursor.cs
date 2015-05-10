using UnityEngine;
using System.Collections;

public class LockHideCursor : MonoBehaviour {

	void Awake(){

		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;

	}

}
