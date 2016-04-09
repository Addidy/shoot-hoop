using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            LoadNextScene();
	}

    void LoadNextScene() {
        // Load Scene
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        // Load currentIndex + 1
        SceneManager.LoadScene(currentIndex + 1);
    }
}
