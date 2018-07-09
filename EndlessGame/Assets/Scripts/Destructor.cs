using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {

    private Renderer renderer;

    private void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Obstacle" && renderer.enabled == true)
        {
            Time.timeScale = 0;
        }

    }

}
