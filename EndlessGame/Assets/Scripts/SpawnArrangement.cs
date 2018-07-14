using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArrangement : MonoBehaviour {

    public GameObject[] arrangement;
    public GameObject coin;

    private float timeBetweenSpawns = 7f;
    private float minTimeBetweenSpawns = 3f;
    private float lastTimeSpawned = 0f;
    private float unit = 0.5f;
    private float translateY = 17f;

    private int randomValue;

    private List<List<Vector2>> coinPositions;

    private void Start()
    {
        coinPositions = CoinMatrix.loadPositions();
        InstantiateMesh();
    }

    void Update () {

        timeBetweenSpawns = (minTimeBetweenSpawns * GlobalVars.maxSpeed) / GlobalVars.speed;

        if (Time.time - lastTimeSpawned > timeBetweenSpawns) 
        {
            InstantiateMesh();
            lastTimeSpawned = Time.time;
        }
	}

    void InstantiateMesh()
    {
        randomValue = Random.Range(0, 2);
        if (randomValue == 0)
        {
            InstantiateArrangement();
        }
        else
        {
            InstantiateCoins();
        }
    }

    void InstantiateArrangement()
    {
        randomValue = Random.Range(0, arrangement.Length);
        while (randomValue == arrangement.Length) // exclude the maximum value to have no exception
        {
            randomValue = Random.Range(0, arrangement.Length);
        }

        Instantiate(arrangement[randomValue], Vector3.zero, Quaternion.identity);
    }

    void InstantiateCoins()
    {
        randomValue = Random.Range(0, coinPositions.Count);
        while(randomValue == coinPositions.Count) // exclude the maximum value to have no exception
        {
            randomValue = Random.Range(0, coinPositions.Count);
        }

        List<Vector2> positions = coinPositions[randomValue];

        foreach(Vector2 position in positions)
        {
            Instantiate(coin, new Vector3(position.x * unit, position.y * unit - translateY, 0f), coin.transform.rotation);
        }
    }
}
