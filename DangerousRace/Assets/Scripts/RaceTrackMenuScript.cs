using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RaceTrackMenuScript : MonoBehaviour
{

    private bool singlePlayerGame;
    private bool multiplayersGame;
    public GameObject buttons;
    public Text shotDownTimeText;

    private void Start()
    {
        singlePlayerGame = false;
        multiplayersGame = false;
        buttons.SetActive(true);
    }

    private void Update()
    {

    }

    public bool GetSinglePlayerGame()
    {
        return singlePlayerGame;
    }

    public bool GetMultiplayersGame()
    {
        return multiplayersGame;
    }

    public void PlaySinglePlayerGame()
    {
        singlePlayerGame = true;
        buttons.SetActive(false);
    }

    public void PlayMultiPlayerGame()
    {
        multiplayersGame = true;
        buttons.SetActive(false);
    }

    public void BackGame()
    {
        SceneManager.LoadScene("GameMenu");
    }

}
