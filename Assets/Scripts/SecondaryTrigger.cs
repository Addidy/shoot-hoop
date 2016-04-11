using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SecondaryTrigger : MonoBehaviour {

    public int value = 1;
    private Collider expectedCollider;

    public void ExpectCollider(Collider ball) {
        expectedCollider = ball;
    }

    void OnTriggerEnter(Collider collider) {
        if (collider == expectedCollider) {
            ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
            scoreKeeper.IncrementScore(value);
        }
    }
}
