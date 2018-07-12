using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArrangement : MonoBehaviour {

    public GameObject[] arrangement;

    private float timeBetweenSpawns = 7f;
    private float minTimeBetweenSpawns = 3f;
    private float lastTimeSpawned = 0f;
    private int arr = 0;

	void Update () {

        timeBetweenSpawns = (minTimeBetweenSpawns * GlobalVars.maxSpeed) / GlobalVars.speed;

        if (Time.time - lastTimeSpawned > timeBetweenSpawns) 
        {

            Instantiate(arrangement[arr], Vector3.zero, Quaternion.identity);

            arr = (arr + 1) % arrangement.Length;

            lastTimeSpawned = Time.time;

        }

	}
}
