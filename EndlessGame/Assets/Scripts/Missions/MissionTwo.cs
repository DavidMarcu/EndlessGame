using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTwo : Mission {

    public MissionTwo()
    {
        selfIndex = 2;
    }

    public override void MissionLogic()
    {
        print("misiunea doi");
        if (GlobalVars.coins > 50)
        {
            PlayerPrefs.SetInt("MissionIndex", selfIndex + 1);
        }
    }
}
