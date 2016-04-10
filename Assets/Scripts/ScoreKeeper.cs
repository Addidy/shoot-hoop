using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    private int score = 0;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public int GetScore() {
        return score;
    }

    public void IncrementScore(int value) {
        score += value;
        print("Ball Hit Target, score: " + score);
    }
}
