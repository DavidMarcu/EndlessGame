using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

    public Canvas timer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            GlobalVars.coins++;
            Destroy(other.gameObject);
        }
        else
        {
            if (other.gameObject.tag == "PowerUpOne")
            {
                Destroy(other.gameObject);
                StartCoroutine(SuperSpeed());
            }
        }
    }

    IEnumerator SuperSpeed()
    {
        GlobalVars.canPlayerAct = false;
        GlobalVars.speed = GlobalVars.ultraSpeed;
        GlobalVars.maxSpeed = GlobalVars.ultraSpeed;
        GlobalVars.canPlayerDestroy = true;
        Canvas clock = Instantiate(timer);
        yield return new WaitForSecondsRealtime(GlobalVars.ultraSpeedTime);
        Destroy(clock.gameObject);
        GlobalVars.canPlayerDestroy = false;
        GlobalVars.canPlayerAct = true;
        GlobalVars.speed = GlobalVars.normalSpeed;
        GlobalVars.maxSpeed = GlobalVars.normalSpeed;
    }

}
