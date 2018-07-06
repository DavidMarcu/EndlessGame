using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour {

    public GameObject bullet;
    private bool canShoot = true;
    public float delayShotSeconds = 0.25f;

    void Update () {

        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            Instantiate(bullet, new Vector3(this.transform.position.x, this.transform.position.y - this.transform.localScale.y, this.transform.position.z), Quaternion.identity);
            canShoot = false;
            StartCoroutine(ShootsDelay());
        }

    }

    IEnumerator ShootsDelay()
    {
        yield return new WaitForSeconds(delayShotSeconds);
        canShoot = true;
    }
}
