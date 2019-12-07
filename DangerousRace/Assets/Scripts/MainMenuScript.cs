using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    //private bool isMultiplayerGame = false;

    public void PlayGame()
    {
        SceneManager.LoadScene("RaceTrack");
    }
    /*
    public void PlayMultiplayerGame()
    {
        
        bool isMultiplayerGame = true;
        setMultiplayerGame(isMultiplayerGame);
        Debug.Log("Rezultat " + isMultiplayerGame.ToString());
        
        SceneManager.LoadScene("RaceTrack");
    }
    */
    /*
    public void NumbeOfPlayers()
    {
        if (isMultiplayerGame == true)
        {
            SceneManager.LoadScene("RaceTrack");
        } else
        {
            SceneManager.LoadScene("RaceTrack");
        }
    }
    */
    /*
    public bool getMultiplayerGame()
    {

        isMultiplayerGame = true;
        return isMultiplayerGame;

        return isMultiplayerGame;
    }

    public void setMultiplayerGame(bool isMultiplayerGame)
    {
        this.isMultiplayerGame = isMultiplayerGame;
    }
    */

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("WYSZEDLES");
    }

}
