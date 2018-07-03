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
    public float yPosition = 0.0f;
    public float zPosition = 0.0f;

    public float speed = 5;
    private Rigidbody rb2d;
    public Boundary boundary;
    private bool onAndroid = true;

    private void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            onAndroid = true;
            speed *= 2;
        }
        else
        {
            onAndroid = false;
        }

        rb2d = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 inputAccelerometer;
        float horizontal;

        if (onAndroid)
        {
            inputAccelerometer = Input.acceleration;
            horizontal = inputAccelerometer.x;
        }
        else
        {

            horizontal = Input.GetAxis("Horizontal");
        }

        Vector3 movement = new Vector3(horizontal, 0.0f, 0.0f);
        rb2d.velocity = movement * speed;

        rb2d.position = new Vector3(Mathf.Clamp(rb2d.position.x, boundary.xMin, boundary.xMax), yPosition, zPosition);
    }
}