using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasScript : MonoBehaviour {

    public Camera playerCamera;
    public Camera playerTwoCamera;
    public Camera backCameraOne;
    public Camera backCameraTwo;
    public GameObject playerOneObj;
    public GameObject playerTwoObj;

    private bool singlePlayerGame;
    private bool multiplayersGame;
    private RaceTrackMenuScript raceTrackMenuScript;

    void Start ()
    {

        playerCamera.enabled = false;
        backCameraOne.enabled = false;
        //backCameraOne.enabled = true;
        //backCameraOne.rect = new Rect(0.175f, 0.8f, 0.65f, 0.2f);

        playerTwoCamera.enabled = false;
        backCameraTwo.enabled = false;

        singlePlayerGame = false;
        multiplayersGame = false;
        raceTrackMenuScript = FindObjectOfType<RaceTrackMenuScript>();

    }

	void FixedUpdate ()
    {
        /*
        backCameraOne.enabled = true;
        backCameraOne.rect = new Rect(0.175f, 0.8f, 0.65f, 0.2f);
        */

        singlePlayerGame = raceTrackMenuScript.GetSinglePlayerGame();
        multiplayersGame = raceTrackMenuScript.GetMultiplayersGame();
        if (singlePlayerGame)
        {
            playerOneObj.SetActive(true);
            playerCamera.enabled = true;
        }

        if (multiplayersGame)
        {
            playerOneObj.SetActive(true);
            playerCamera.enabled = true;
            playerCamera.rect = new Rect(0.0f, 0.5f, 1.0f, 0.5f);

            playerTwoObj.SetActive(true);
            playerTwoCamera.enabled = true;
            playerTwoCamera.rect = new Rect(0.0f, 0.0f, 1.0f, 0.5f);
        }

	}
}
