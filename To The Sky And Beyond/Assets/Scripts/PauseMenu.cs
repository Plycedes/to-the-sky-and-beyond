using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;  //To Check if game is paused

    public GameObject pauseMenuUI;
    public GameObject gameMenuUI;

    public void PauseButton()  //To give the pause button power to pause
    {
        GameIsPaused = true;        
    }

    /*private void Update()  //Logic to pause or resume
    {
        if (GameIsPaused == true)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }*/

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        gameMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        gameMenuUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
}
