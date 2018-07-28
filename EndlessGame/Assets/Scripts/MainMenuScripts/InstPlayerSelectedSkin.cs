using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstPlayerSelectedSkin : MonoBehaviour {

    public GameObject[] playerSkins;

    void Start()
    {
        Instantiate(playerSkins[PlayerPrefs.GetInt("SettedSkinIndex", 0)], this.transform.position, this.transform.rotation);
    }
}
