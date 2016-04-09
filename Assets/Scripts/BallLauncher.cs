using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    public GameObject BallPrefab;
    public float speed;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            GameObject instance = Instantiate(BallPrefab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            Quaternion rot = transform.rotation;
            rb.velocity = rot * Vector3.forward * speed;
        }
    }
}
