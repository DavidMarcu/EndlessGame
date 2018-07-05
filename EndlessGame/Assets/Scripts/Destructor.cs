using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {

    private bool touchingPortal = false;
    public float wrapSpace = 0.3f;
    private float lastPlayerSpeed;
    private Movement playerMovement;

    private void Start()
    {
        playerMovement = this.GetComponent<Movement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!touchingPortal)
        {
            if(collision.gameObject.tag == "FakeObstacle" ||
               collision.gameObject.tag == "TrueObstacle")
            {
                Time.timeScale = 0;
            }
        }

        if (collision.gameObject.tag == "Portal")
        {
            if(Mathf.Abs(collision.gameObject.transform.position.x - this.transform.position.x) < wrapSpace)
            {
                //Debug.Log("collision");
                touchingPortal = true;
                lastPlayerSpeed = playerMovement.speed;
                playerMovement.speed = 0;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Portal")
        {
            touchingPortal = false;
            playerMovement.speed = lastPlayerSpeed;
        }
    }

}
