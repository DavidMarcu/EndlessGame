﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mission : MonoBehaviour {

    public string title;
    public string description;
    public int selfIndex;
    public bool isFinished;

    public string firstTask = "";
    public string secondTask = "";
    public string thirdTask = "";
    
    public abstract void MissionLogic();

}
