using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        //print(other.gameObject.tag + " " + GlobalVars.canPlayerAct + "<<<<<<<<<<<<<<<");

        if(other.gameObject.tag == "Obstacle" && GlobalVars.canPlayerAct)
        {
            PlayerPrefs.SetInt("TotalCoins", PlayerPrefs.GetInt("TotalCoins", 0) + GlobalVars.coins); // save all the player coins
            Time.timeScale = 0;
            GlobalVars.isGameOn = false;
            GlobalVars.canPlayerAct = false;
        }
        else
        {
            if(other.gameObject.tag == "Obstacle" && GlobalVars.canPlayerDestroy)
            {
                Destroy(other.gameObject);
            }
        }

    }

}
