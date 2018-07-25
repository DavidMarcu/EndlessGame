using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
    public GameObject missionsManager;
    private List<Mission> missions = new List<Mission>();
    private int missionIndex;

    private void Start()
    {
        missions.Add(missionsManager.GetComponent<MissionZero>());
        missions.Add(missionsManager.GetComponent<MissionOne>());
        missions.Add(missionsManager.GetComponent<MissionTwo>());
        PlayerPrefs.SetInt("MissionIndex", 0);
    }

    private void Update()
    {
        missionIndex = PlayerPrefs.GetInt("MissionIndex", 0);
        if (missionIndex < missions.Count)
        {
            missions[missionIndex].MissionLogic();
        }
    }
}
