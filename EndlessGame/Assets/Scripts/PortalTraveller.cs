using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTraveller : MonoBehaviour {

    private new Renderer renderer;
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
            movement.canMove = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ExitPortal")
        {
            renderer.enabled = true;
            movement.canMove = true;
        }

    }


}
