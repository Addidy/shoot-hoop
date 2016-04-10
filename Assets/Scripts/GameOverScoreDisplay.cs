using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScoreDisplay : MonoBehaviour {

    Text text;
    ScoreAbsorber scoreAbsorber;

    // Use this for initialization
    void Start() {
        text = GetComponent<Text>();
        scoreAbsorber = FindObjectOfType<ScoreAbsorber>();
        text.text = "Score: " + scoreAbsorber.score;
    }
}