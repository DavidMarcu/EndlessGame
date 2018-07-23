using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mission : MonoBehaviour {

    public string title;
    public bool isFinished;
    public int selfIndex;

    public abstract void MissionLogic();

}
