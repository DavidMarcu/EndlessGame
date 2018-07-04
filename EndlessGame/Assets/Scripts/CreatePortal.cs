using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePortal : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "FakeObstacle")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
