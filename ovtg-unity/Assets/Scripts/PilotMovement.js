#pragma strict

var go : GameObject;

function Start () {

}

function Update () {
	if (Input.GetKey("w")) {
		transform.Translate(Vector3.forward * (Time.deltaTime*2));
	}
	if (Input.GetKey("s")) {
		transform.Translate(Vector3.back * (Time.deltaTime*2));
	}
	if (Input.GetKey("a")) {
		transform.Translate(Vector3.left * (Time.deltaTime*2));
	}
	if (Input.GetKey("d")) {
		transform.Translate(Vector3.right * (Time.deltaTime*2));
	}
}