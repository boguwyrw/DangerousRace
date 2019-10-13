using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour {

    [SerializeField]
    private float playerMovmentSpeed = 15.0f;
    [SerializeField]
    private float playerRotationSpeed = 50.0f;

    private bool isCarBackUp = false;
    private Vector3 playerResetPosition;
    private float playerRotationY = 0.0f;


    void Start () {
		
	}

	void FixedUpdate () {

        if (Input.GetKey(KeyCode.W))
        {
            isCarBackUp = false;
            transform.Translate(playerMovmentSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            isCarBackUp = true;
            transform.Translate(-playerMovmentSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (isCarBackUp == true)
            {
                transform.Rotate(0.0f, -playerRotationSpeed * Time.deltaTime, 0.0f);
            }
            else { 
                transform.Rotate(0.0f, playerRotationSpeed * Time.deltaTime, 0.0f);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (isCarBackUp == true)
            {
                transform.Rotate(0.0f, playerRotationSpeed * Time.deltaTime, 0.0f);
            }
            else { 
                transform.Rotate(0.0f, -playerRotationSpeed * Time.deltaTime, 0.0f);
            }
        }

        if (Input.GetKey(KeyCode.R))
        {
            if ((transform.localEulerAngles.y > 45.0f) && (transform.localEulerAngles.y < 135.0f))
            {
                transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
            }
            else if ((transform.localEulerAngles.y < 315.0f) && (transform.localEulerAngles.y > 225.0f))
            {
                transform.rotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
            }
            else if ((transform.localEulerAngles.y > 135.0f) && (transform.localEulerAngles.y < 225.0f))
            {
                transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
            }
            else {
                transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            }
        }

        if (transform.position.y < -1.0f)
        {
            transform.position = new Vector3(playerResetPosition.x, 0.5f, playerResetPosition.z);
            transform.rotation = Quaternion.Euler(0.0f, playerRotationY, 0.0f);
        }

    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            playerResetPosition = other.transform.position;
            //playerRotationY = other.transform.rotation.y;
            playerRotationY = other.transform.localEulerAngles.y; 
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {
            playerMovmentSpeed = 5.0f;
            playerRotationSpeed = 100.0f;
        }
        if (collision.gameObject.CompareTag("Sand"))
        {
            playerMovmentSpeed = 7.0f;
            playerRotationSpeed = 15.0f;
        }
        if (collision.gameObject.CompareTag("Ice"))
        {
            playerMovmentSpeed = 12.0f;
            playerRotationSpeed = 180.0f;
        }

        if (collision.gameObject.CompareTag("Street"))
        {
            playerMovmentSpeed = 15.0f;
            playerRotationSpeed = 50.0f;
        }
        
    }

}
