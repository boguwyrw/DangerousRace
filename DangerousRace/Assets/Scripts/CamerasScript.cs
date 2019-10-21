using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasScript : MonoBehaviour {

    public Camera playerCamera;
    public Camera playerTwoCamera;
    public Camera backCameraOne;
    public Camera backCameraTwo;

    public GameObject playerTwoObj;


    void Start () {
        //playerCamera = Camera.main;
        playerCamera.enabled = true;
        backCameraOne.enabled = false;
        //backCameraOne.enabled = true;
        //backCameraOne.rect = new Rect(0.175f, 0.8f, 0.65f, 0.2f);

        playerTwoCamera.enabled = false;
        backCameraTwo.enabled = false;

    }

	void FixedUpdate () {
        /*
        backCameraOne.enabled = true;
        backCameraOne.rect = new Rect(0.175f, 0.8f, 0.65f, 0.2f);
        */
        if (playerTwoObj.active)
        {
            playerCamera.rect = new Rect(0.0f, 0.5f, 1.0f, 0.5f);

            playerTwoCamera.enabled = true;
            playerTwoCamera.rect = new Rect(0.0f, 0.0f, 1.0f, 0.5f);  
        }
        
	}
}
