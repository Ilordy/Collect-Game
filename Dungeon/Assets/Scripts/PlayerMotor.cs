using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour{

    CharacterController controller;
    Vector3 playerVelocity;
    public float speed = 5f;

    void Start(){
        controller = GetComponent<CharacterController>();
    }

    void Update(){
        
    }

    public void ProcessMove(Vector2 input) {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
    }
}
