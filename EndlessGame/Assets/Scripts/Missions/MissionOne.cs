using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionOne : Mission {

    public MissionOne()
    {
        selfIndex = 1;
    }

	public override void MissionLogic()
    {
        print("misiunea unu");
        if(GlobalVars.coins > 25)
        {
            PlayerPrefs.SetInt("MissionIndex", selfIndex + 1);
        }
    }

}
