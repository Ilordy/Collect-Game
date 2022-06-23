using System.Collections;
using UnityEngine;

public abstract class Interactable : MonoBehaviour {

    protected Coroutine CollectCoroutine = null;

    protected float respawn;
    protected int health;
    protected bool active; //standard: 0: exhausted, 1: active

    public void BaseInteract() {
        Interact();
    }

    public void BaseCancel() {
        Cancel();
    }

    protected virtual void Interact() {
        if (!active) return;
        CollectCoroutine = StartCoroutine(Collect());
    }

    protected virtual void Cancel() {
        if (!active) return;
        if (CollectCoroutine != null) { StopCoroutine(CollectCoroutine); CollectCoroutine = null; }
    }

    protected virtual void Exhaust() {
        active = false;
        Debug.Log("Entity Exhausted.");
        StartCoroutine(Respawn());
    }

    protected virtual IEnumerator Collect() {
        while(true) {
            yield return new WaitForSeconds(1f); // Need to get player weapon upgrade for speed here.
            if (health <= 0) {
                if(active) Exhaust();
                yield return new WaitForSeconds(0.1f);
                continue;
            }
            health--; // Need to get player weapon upgrade for damage here.
            Debug.Log("Collecting...");
        }
    }

    protected virtual IEnumerator Respawn() {
        yield return new WaitForSeconds(respawn);
        active = true;
        health = 5;
        Debug.Log("Entity is active.");
        yield break;
    }
}
