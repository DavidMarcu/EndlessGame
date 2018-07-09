using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTraveller : MonoBehaviour {

    private Renderer renderer;
    private Movement movement;

    private void Start()
    {
        renderer = this.GetComponent<Renderer>();
        movement = this.GetComponent<Movement>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Portal")
        {
            renderer.enabled = false;
            movement.isMoving(false);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ExitPortal")
        {
            renderer.enabled = true;
            movement.isMoving(true);
        }

    }


}
