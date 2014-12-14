using UnityEngine;
using System.Collections;

public class PilotMove : MonoBehaviour {

    public float moveSpeedMultiplier;

    CharacterController cc;
    void Start() {
        cc = GetComponentInParent<CharacterController>();
        moveSpeedMultiplier = 15;
    }

    void Update() {
        cc.Move(((transform.right * (Input.GetAxis("Horizontal"))) + (transform.forward * (Input.GetAxis("Vertical")))) * moveSpeedMultiplier * Time.deltaTime);
    }
}
