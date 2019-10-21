using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour {

    [SerializeField]
    private float playerMovmentSpeed = 15.0f;
    [SerializeField]
    private float playerRotationSpeed = 50.0f;

    private int numberOfCheckpoints = 0;

    private bool isCarBackUp = false;
    private Vector3 playerResetPosition;
    private float playerRotationY = 0.0f;
    private float restartPlayerDelay = 2.0f;

    //public GameObject playerOneObj;
    public GameObject playerTwoObj;

    void Start () {
        playerTwoObj.SetActive(false);
    }

	void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.P))
        {
            playerTwoObj.SetActive(true);
        }
        FirstPlayerMovement();
        SecondPlayerMovement();
        
    }

    // poruszanie graczem numer jeden
    private void FirstPlayerMovement()
    {

        if (gameObject.CompareTag("Player"))
        {
            //Debug.Log("Liczba checkpointow " + numberOfCheckpoints.ToString());
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
                else
                {
                    transform.Rotate(0.0f, playerRotationSpeed * Time.deltaTime, 0.0f);
                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                if (isCarBackUp == true)
                {
                    transform.Rotate(0.0f, playerRotationSpeed * Time.deltaTime, 0.0f);
                }
                else
                {
                    transform.Rotate(0.0f, -playerRotationSpeed * Time.deltaTime, 0.0f);
                }
            }

            if (Input.GetKey(KeyCode.R))
            {
                RotationRestart();
            }

            RestartPosition();
        }

    }

    // poruszenie graczem numer dwa
    private void SecondPlayerMovement()
    {

        if(gameObject.CompareTag("PlayerTwo"))
        { 

            if (Input.GetKey(KeyCode.UpArrow))
            {
                isCarBackUp = false;
                transform.Translate(playerMovmentSpeed * Time.deltaTime, 0.0f, 0.0f);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                isCarBackUp = true;
                transform.Translate(-playerMovmentSpeed * Time.deltaTime, 0.0f, 0.0f);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (isCarBackUp == true)
                {
                    transform.Rotate(0.0f, -playerRotationSpeed * Time.deltaTime, 0.0f);
                }
                else
                {
                    transform.Rotate(0.0f, playerRotationSpeed * Time.deltaTime, 0.0f);
                }
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (isCarBackUp == true)
                {
                    transform.Rotate(0.0f, playerRotationSpeed * Time.deltaTime, 0.0f);
                }
                else
                {
                    transform.Rotate(0.0f, -playerRotationSpeed * Time.deltaTime, 0.0f);
                }
            }

            if (Input.GetKey(KeyCode.RightShift))
            {
                RotationRestart();
            }

            RestartPosition();
        }

    }

    private void RotationRestart()
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
        else
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }
    }

    // restartowanie pozycji gracza po wypadnieciu z trasy
    private void RestartPosition()
    {
        if (transform.position.y < -1.0f)
        {
            Invoke("RestartPlayer", restartPlayerDelay);
        }
    }

    private void RestartPlayer()
    {
        transform.position = new Vector3(playerResetPosition.x, 0.5f, playerResetPosition.z);
        transform.rotation = Quaternion.Euler(0.0f, playerRotationY, 0.0f);
    }

    // checkpoint
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint"))
        {
            playerResetPosition = other.transform.position;
            playerRotationY = other.transform.localEulerAngles.y;
            numberOfCheckpoints++;
        }
    }

    // informacje o rodzaju kolizji z nawierzchnia - OnCollisionEnter
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
