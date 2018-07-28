using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour {

    public Text uiCoinsEarned;

    public Canvas powerUpOne;
    public Canvas powerUpTwo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            if (GlobalVars.areCoinsDuplicated)
            {
                GlobalVars.coins += 2;
                Destroy(other.gameObject);
            }
            else
            {
                GlobalVars.coins++;
                Destroy(other.gameObject);
            }
            uiCoinsEarned.text = GlobalVars.coins.ToString();
            print("Coins" + GlobalVars.coins);
        }
        else
        {
            if (other.gameObject.tag == "PowerUpOne")
            {
                PlayerPrefs.SetInt("mSuperSpeedCollected", PlayerPrefs.GetInt("mSuperSpeedCollected", 0) + 1);
                Destroy(other.gameObject);
                StartCoroutine(SuperSpeed());
            }
            else
            {
                if (other.gameObject.tag == "PowerUpTwo")
                {
                    Destroy(other.gameObject);
                    StartCoroutine(DuplicateCoins());
                }
            }
        }
    }

    IEnumerator SuperSpeed()
    {
        GlobalVars.canPlayerAct = false;
        GlobalVars.speed = GlobalVars.ultraSpeed;
        GlobalVars.maxSpeed = GlobalVars.ultraSpeed;
        GlobalVars.canPlayerDestroy = true;
        Canvas clock = Instantiate(powerUpOne);
        yield return new WaitForSeconds(GlobalVars.powerUpEffectTime);
        Destroy(clock.gameObject);
        GlobalVars.canPlayerDestroy = false;
        GlobalVars.canPlayerAct = true;
        GlobalVars.speed = GlobalVars.normalSpeed;
        GlobalVars.maxSpeed = GlobalVars.normalSpeed;
    }

    IEnumerator DuplicateCoins()
    {
        GlobalVars.areCoinsDuplicated = true;
        Canvas clock = Instantiate(powerUpTwo);
        yield return new WaitForSeconds(GlobalVars.powerUpEffectTime);
        GlobalVars.areCoinsDuplicated = false;
        Destroy(clock.gameObject);
    }

}
