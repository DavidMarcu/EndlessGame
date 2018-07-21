using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsDestroyer : MonoBehaviour {

    SpawnArrangement spawnArrangement;

    private void Start()
    {
        spawnArrangement = GetComponent<SpawnArrangement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "TriggSpawn")
        {
            spawnArrangement.InstantiateMesh();
        }

        Destroy(other.gameObject);
    }
}
