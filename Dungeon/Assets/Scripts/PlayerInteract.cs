using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    public LayerMask mask;
    private BoxCollider boxCollider;

    void Start() {
        boxCollider = GetComponent<BoxCollider>();
    }

    void OnTriggerEnter(Collider col) {
        if(col.gameObject.TryGetComponent(out Interactable interactable)) interactable.BaseInteract();
    }

    void OnTriggerExit(Collider col) {
        if(col.gameObject.TryGetComponent(out Interactable interactable)) interactable.BaseCancel();
    }
}
