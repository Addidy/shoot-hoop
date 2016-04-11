using UnityEngine;
using System.Collections;

public class PrimaryTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider collider) {
        GetComponentInChildren<SecondaryTrigger>().ExpectCollider(collider);
    }
}
