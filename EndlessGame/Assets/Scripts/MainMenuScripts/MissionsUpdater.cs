using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionsUpdater : MonoBehaviour {

    public GameObject gameLogic;
    private MissionManager missionManager;

    public Text missionTitle;
    public Text missionDescription;

    public Text firstTask;
    public Text secondTask;
    public Text thirdTask;


    private void Start()
    {
        missionManager = gameLogic.GetComponent<MissionManager>();
    }

    void Update () {
        missionTitle.text = "#" + missionManager.GetMissionIndex() + " " + missionManager.GetMissionTitle();
        missionDescription.text = missionManager.GetMissionDescription();
        firstTask.text = missionManager.GetFirstTask();
        secondTask.text = missionManager.GetSecondTask();
        thirdTask.text = missionManager.GetThirdTask();
    }
}
