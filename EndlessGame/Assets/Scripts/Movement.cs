using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax;
}

public class Movement : MonoBehaviour
{
    private Rigidbody rb2d;
    public Boundary boundary;
    public bool canMove = true;
    private float horizontal;
    
    private void Start()
    {
        rb2d = GetComponent<Rigidbody>();
    }
   
    private void FixedUpdate()
    {
        if (canMove)
        {
            horizontal = Input.GetAxis("Horizontal");

            Vector3 movement = new Vector3(horizontal, 0.0f, 0.0f);
            rb2d.velocity = movement * GlobalVars.speed;
            rb2d.position = new Vector3(Mathf.Clamp(rb2d.position.x, boundary.xMin, boundary.xMax), this.transform.position.y, this.transform.position.z);
        }
        else
        {
            rb2d.velocity = Vector3.zero;
            rb2d.position = this.transform.position;
        }
    }

}