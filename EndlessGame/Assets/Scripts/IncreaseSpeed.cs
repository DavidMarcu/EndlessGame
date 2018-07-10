using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeed : MonoBehaviour {

    private float speedInc = 0.1f;

	void Update () {

        if(GlobalVars.speed < 10)
        {
            GlobalVars.speed += speedInc * Time.deltaTime;
        }
	}
}
