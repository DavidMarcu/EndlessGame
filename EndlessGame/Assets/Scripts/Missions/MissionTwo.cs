using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionTwo : Mission {

    public MissionTwo()
    {
        selfIndex = 2;
        title = "Mission 2";
        description = "Great job, you become better with each try!";
        isFinished = false;
    }

    public override void MissionLogic()
    {
        print("misiunea doi" + PlayerPrefs.GetInt("ScoreMultiplier"));
        if (isFinished)
        {
            PlayerPrefs.SetInt("ScoreMultiplier", PlayerPrefs.GetInt("ScoreMultiplier", 1) + 1); // score multiplier needs to be reseted after replaying the game
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
        return true;
    }
}
