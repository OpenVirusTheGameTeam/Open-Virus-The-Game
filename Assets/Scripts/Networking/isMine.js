#pragma strict

function Awake() {

Debug.Log("Checking if player spawned local...");

if (!GetComponent.<NetworkView>().isMine){ 

GetComponentInChildren(Camera).enabled = false; // disable the camera of the non-owned Player
GetComponentInChildren(AudioListener).enabled = false; // Disables AudioListener of non-owned Player - prevents multiple AudioListeners from being present in scene. 
GetComponentInChildren(MouseLook).enabled = false; 
GetComponentInChildren(PilotMove).enabled = false;
GetComponentInChildren(PlasmaLauncher).enabled = false; 


} 

}