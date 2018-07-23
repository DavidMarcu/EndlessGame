using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionZero : Mission {

    public MissionZero()
    {
        selfIndex = 0;
    }

    public override void MissionLogic()
    {
        print("misiunea zero");
        if (GlobalVars.coins > 10)
        {
            PlayerPrefs.SetInt("MissionIndex", selfIndex + 1);
        }
    }

}
