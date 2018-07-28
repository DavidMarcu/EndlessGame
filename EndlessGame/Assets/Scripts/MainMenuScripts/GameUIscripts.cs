using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIscripts : MonoBehaviour {

    private bool isPaused = false;

    public GameObject confirmationWindow;
    public GameObject pauseGameWindow;

    public void PauseTheGame()
    {
        if (GlobalVars.isGameOn)
        {
            if (!isPaused)
            {
                Time.timeScale = 0;
                isPaused = true;
                pauseGameWindow.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                isPaused = false;
                CloseConfirmationWindow();
                pauseGameWindow.SetActive(false);
            }
        }
    }

    public void OpenConfirmationWindow()
    {
        if (!confirmationWindow.activeSelf)
        {
            confirmationWindow.SetActive(true);
        }
    }

    public void CloseConfirmationWindow()
    {
        if (confirmationWindow.activeSelf)
        {
            confirmationWindow.SetActive(false);
        }
    }

    public void GoToMainMenu()
    {
        PlayerPrefs.SetInt("TotalCoins", PlayerPrefs.GetInt("TotalCoins", 0) + GlobalVars.coins); // save all the player coins
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

}
