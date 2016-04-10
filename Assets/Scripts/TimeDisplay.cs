using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeDisplay : MonoBehaviour {

    Text text;
    LevelManager levelManager;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        levelManager = FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if (levelManager.timeTillNextLevel > 0)
            text.text = "Time remaining: " + levelManager.timeTillNextLevel;
        else
            text.text = "Time remaining: 0";
    }
}
