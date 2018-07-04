using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour {

    public GameObject bullet;

    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, new Vector3(this.transform.position.x - this.transform.localScale.x, this.transform.position.y - this.transform.localScale.y, this.transform.position.z), Quaternion.identity);
        }

    }
}
