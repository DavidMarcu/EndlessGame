using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject confirmationWindow;

	public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void QuitGame()
    {
        Application.Quit();
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

}
