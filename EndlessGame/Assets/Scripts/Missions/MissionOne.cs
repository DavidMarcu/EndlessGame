using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionOne : Mission {

    public MissionOne()
    {
        selfIndex = 1;
        title = "Mission 1";
        description = "Okay, let's try something different now!";
        isFinished = false;
    }

	public override void MissionLogic()
    {
        print("misiunea unu" + PlayerPrefs.GetInt("ScoreMultiplier"));
        if (isFinished)
        {
            PlayerPrefs.SetInt("ScoreMultiplier", PlayerPrefs.GetInt("ScoreMultiplier", 1) + 1);
            PlayerPrefs.SetInt("MissionIndex", selfIndex + 1);
        }
        else
        {
            if (FirstTask())
            {
                isFinished = true;
            }
        }
    }

    private bool FirstTask()
    {

        if (PlayerPrefs.GetInt("mSuperSpeedCollected", 0) >= 10)
        {
            return true;
        }
        return false;
    }

}
