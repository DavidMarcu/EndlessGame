using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour {

    public GameObject bullet;
    private bool canShoot = true;
    public float delayShotSeconds;
    private float lastTime = 0.0f;

    void Update () {

        delayShotSeconds = (0.8f * GlobalVars.maxSpeed) / GlobalVars.speed; // 0.8 is the minimum value for delayShotSeconds

        if (canShoot)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, new Vector3(this.transform.position.x, this.transform.position.y - this.transform.localScale.y + 0.5f, this.transform.position.z), Quaternion.identity);
                canShoot = false;
                lastTime = Time.time;
            }
        }
        else
        {
            if(Time.time - lastTime > delayShotSeconds)
            {
                canShoot = true;
            }
        }
    }
}
