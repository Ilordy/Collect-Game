using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour {

    private Inputs playerInputs;
    private Inputs.NormalActions normal;
    private PlayerMotor motor;
    
    void Awake() {
        playerInputs = new Inputs();
        normal = playerInputs.Normal;
        motor = GetComponent<PlayerMotor>();
    }

    void FixedUpdate(){
        motor.ProcessMove(normal.Movement.ReadValue<Vector2>());
    }

    void OnEnable() {
        normal.Enable();
    }

    void OnDisable() {
        normal.Disable();
    }
}
