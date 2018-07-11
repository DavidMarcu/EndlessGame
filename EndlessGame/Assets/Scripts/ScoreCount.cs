using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour {

    private float score = 0f;

    private void Update()
    {
        score += GlobalVars.scoreMultiplier * Time.deltaTime;
        print((int)score);
    }

}
