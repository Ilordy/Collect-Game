using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : Interactable {
    protected void Start() {
        active = true;
        health = 5;
        respawn = 5f;
    }
}
