using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour {

    private float rotateSpeed = 50f; 

	void Update () {

        rotateSpeed = 50f * GlobalVars.speed; 

        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);

    }
}
