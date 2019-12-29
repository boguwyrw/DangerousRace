using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RaceTrackMenuScript : MonoBehaviour {

    public GameObject playerOne;
    public GameObject playerTwo;
    //public GameObject camera;
    public GameObject buttons;

    private bool isPlaying = false;
    private float shotDownTime = 5;

    void Start()
    {
        buttons.SetActive(true);
    }

    void Update()
    {
        ShotDownButtons();
        if (isPlaying)
        {
            buttons.SetActive(false);
        }
        
    }

    public void PlaySinglePlayerGame()
    {
        playerOne.SetActive(true);
        playerTwo.SetActive(false);
        //camera.SetActive(false);
        //ShotDownButtons();
    }

    public void PlayMultiPlayerGame()
    {
        playerOne.SetActive(true);
        playerTwo.SetActive(true);
        //camera.SetActive(false);
        //ShotDownButtons();
    }

    public void BackGame()
    {
        SceneManager.LoadScene("GameMenu");
    }

    void ShotDownButtons()
    {
        shotDownTime -= Time.deltaTime;
        if (shotDownTime <= 0.0f)
        {
            isPlaying = true;
        }
    }

}
