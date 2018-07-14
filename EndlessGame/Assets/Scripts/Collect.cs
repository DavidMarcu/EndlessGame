using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

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
        GlobalVars.speed = 20f;
        GlobalVars.canPlayerDestroy = true;
        yield return new WaitForSecondsRealtime(5f);
        GlobalVars.canPlayerDestroy = false;
        GlobalVars.canPlayerAct = true;
        GlobalVars.speed = 10f;
    }

}
