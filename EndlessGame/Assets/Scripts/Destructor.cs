using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Obstacle" && GlobalVars.canPlayerAct)
        {
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
