using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RaceTrackMenuScript : MonoBehaviour {

    public GameObject playerOne;
    public GameObject playerTwo;
    //public GameObject camera;

    public void PlaySinglePlayerGame()
    {
        playerOne.SetActive(true);
        playerTwo.SetActive(false);
        //camera.SetActive(false);
    }

    public void PlayMultiPlayerGame()
    {
        playerOne.SetActive(true);
        playerTwo.SetActive(true);
        //camera.SetActive(false);
    }

    public void BackGame()
    {
        SceneManager.LoadScene("GameMenu");
    }

}
