using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstantiatePlayerSkin : MonoBehaviour {

    public GameObject[] playerSkins;
    private GameObject displayedSkin;
    private int skinIndex;

    void Start () {
        displayedSkin = Instantiate(playerSkins[PlayerPrefs.GetInt("SettedSkinIndex", 0)], this.transform.position, this.transform.rotation);
	}
	
    public void ChangeSkinIndex(int index)
    {
        skinIndex = index;
        PlayerPrefs.SetInt("SkinIndex", index);
        Destroy(displayedSkin);
        displayedSkin = Instantiate(playerSkins[index], this.transform.position, this.transform.rotation);
    }

    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SetSkin()
    {
        PlayerPrefs.SetInt("SettedSkinIndex", skinIndex);
    }
}
