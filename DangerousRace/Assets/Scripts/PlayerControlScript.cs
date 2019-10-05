using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour {

    [SerializeField]
    private float playerMovmentSpeed = 15.0f;
    [SerializeField]
    private float playerRotationSpeed = 50.0f;

    private bool isCarBackUp = false;

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
        
        if (collision.gameObject.CompareTag("Street"))
        {
            playerMovmentSpeed = 15.0f;
            playerRotationSpeed = 50.0f;
        }
        
    }

}
