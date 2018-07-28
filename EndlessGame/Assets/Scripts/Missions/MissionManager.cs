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
        //PlayerPrefs.SetInt("MissionIndex", 0); // sets each new game to restart missions
    }

    private void Update()
    {
        missionIndex = PlayerPrefs.GetInt("MissionIndex", 0);
        if (missionIndex < missions.Count)
        {
            missions[missionIndex].MissionLogic();
        }
    }

    public string GetMissionTitle()
    {
        return missions[PlayerPrefs.GetInt("MissionIndex", 0)].title;
    }

    public string GetMissionDescription()
    {
        return missions[PlayerPrefs.GetInt("MissionIndex", 0)].description;
    }

    public int GetMissionIndex()
    {
        return PlayerPrefs.GetInt("MissionIndex", 0); ;
    }

    public string GetFirstTask()
    {
        return missions[PlayerPrefs.GetInt("MissionIndex", 0)].firstTask;
    }

    public string GetSecondTask()
    {
        return missions[PlayerPrefs.GetInt("MissionIndex", 0)].secondTask;
    }

    public string GetThirdTask()
    {
        return missions[PlayerPrefs.GetInt("MissionIndex", 0)].thirdTask;
    }
}
