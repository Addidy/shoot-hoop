using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

    private Camera camera;
    
	// Use this for initialization
	void Start () {
        camera = GetComponentInChildren<Camera>();
    }

	// Update is called once per frame
	void Update () {
        float rotationSpeed = 5;
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        camera.transform.rotation *= Quaternion.Euler(-mouseY, 0, 0);
        transform.rotation *= Quaternion.Euler(0, mouseX, 0);
	}
}
