using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionZero : Mission {

    public MissionZero()
    {
        selfIndex = 0;
        title = "Mission 0";
        description = "Let's get started";
        isFinished = false;
    }

    public override void MissionLogic()
    {
        print("misiunea zero" + PlayerPrefs.GetInt("ScoreMultiplier", 1));
        if (isFinished)
        {
            PlayerPrefs.SetInt("ScoreMultiplier", PlayerPrefs.GetInt("ScoreMultiplier", 1) + 1);
            PlayerPrefs.SetInt("MissionIndex", selfIndex + 1);
        }
        else
        {
            if(FirstTask() && SecondTask())
            {
                isFinished = true;
            }
        }
    }
    
    private bool FirstTask()
    {
        PlayerPrefs.SetInt("mCoinsInOneRun", GlobalVars.coins);
        print("mCoinsInOneRun = " + PlayerPrefs.GetInt("mCoinsInOneRun", 0));
        if (PlayerPrefs.GetInt("mCoinsInOneRun",0) >= 10)
        {
            return true;
        }
        return false;
    }

    private bool SecondTask()
    {
        PlayerPrefs.SetInt("mScore", (int)GlobalVars.score);
        print("mScore = " + PlayerPrefs.GetInt("mScore", 0));
        if (PlayerPrefs.GetInt("mScore",0) >= 50)
        {
            return true;
        }
        return false;
    }
}
