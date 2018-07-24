using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour
{

    private List<Mission> missions = new List<Mission>();
    private int missionIndex;

    private void Start()
    {
        missions.Add(new MissionZero());
        missions.Add(new MissionOne());
        missions.Add(new MissionTwo());
        PlayerPrefs.SetInt("MissionIndex", 0);
    }

    private void Update()
    {
        missionIndex = PlayerPrefs.GetInt("MissionIndex", 0);

        if (missionIndex < missions.Capacity)
        {
            missions[missionIndex].MissionLogic();
        }
    }
}
