using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasScript : MonoBehaviour {

    private Camera playerCamera;
    public Camera backCamera;

	void Start () {
        playerCamera = Camera.main;
        playerCamera.enabled = true;
        backCamera.enabled = false;


    }

	void FixedUpdate () {
        backCamera.enabled = true;
        backCamera.rect = new Rect(0.175f, 0.8f, 0.65f, 0.2f);
	}
}
