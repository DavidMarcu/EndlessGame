using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour {

    public GameObject confirmationWindow;

    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ResetAllGameData()
    {
        PlayerPrefs.DeleteAll();
        CloseConfirmationWindow();
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
