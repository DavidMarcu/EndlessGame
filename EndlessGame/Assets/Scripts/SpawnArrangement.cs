using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArrangement : MonoBehaviour {

    public GameObject[] arrangement;
    public GameObject coin;

    private float timeBetweenSpawns = 7f;
    private float minTimeBetweenSpawns = 3f;
    private float lastTimeSpawned = 0f;
    private int arr = 0;
    private float unit = 0.5f;
    private float translateY = 6f;

    private List<List<Vector2>> coinPositions;

    private void Start()
    {
        coinPositions = CoinMatrix.loadPositions();
        InstantiateCoins();
    }

    void Update () {

        timeBetweenSpawns = (minTimeBetweenSpawns * GlobalVars.maxSpeed) / GlobalVars.speed;

        if (Time.time - lastTimeSpawned > timeBetweenSpawns) 
        {

            //Instantiate(arrangement[arr], Vector3.zero, Quaternion.identity);
            InstantiateCoins();

            arr = (arr + 1) % arrangement.Length;

            lastTimeSpawned = Time.time;

        }

	}

    void InstantiateCoins()
    {
        List<Vector2> positions = coinPositions[Random.Range(0,coinPositions.Count)]; // can give error when 4 is generated .. :(

        foreach(Vector2 position in positions)
        {
            Instantiate(coin, new Vector3(position.x * unit, position.y * unit - translateY, 0f), coin.transform.rotation);
        }
    }
}
