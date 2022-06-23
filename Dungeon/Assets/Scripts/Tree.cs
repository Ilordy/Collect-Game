using System.Collections;
using UnityEngine;

public class Tree : Interactable {
    protected void Start() {
        active = true;
        health = 5;
        respawn = 5f;
    }
}
