using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDown : MonoBehaviour {

    void FixedUpdate()
    {
        transform.Translate(0.0f, -GlobalVars.speed * Time.deltaTime, 0.0f, Space.World);
    }
}
