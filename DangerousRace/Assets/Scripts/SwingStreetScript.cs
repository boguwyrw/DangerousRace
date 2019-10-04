using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingStreetScript : MonoBehaviour {

    private float rotationSpeed = 10.0f;
    private bool maximumDeviation = false;


    void Start () {
		
	}

	void FixedUpdate () {

        if (transform.localEulerAngles.z > 40.0f) {
            maximumDeviation = true;
        }
        
        if (transform.localEulerAngles.z > 355.0f) {
            maximumDeviation = false;
        }
        
        if (maximumDeviation == false) {
            transform.Rotate(0.0f, 0.0f, rotationSpeed * Time.deltaTime);
        }
  
        if (maximumDeviation == true) {
            transform.Rotate(0.0f, 0.0f, -rotationSpeed * Time.deltaTime);
        }
        
	}
}
