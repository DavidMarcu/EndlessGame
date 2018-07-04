using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePortal : MonoBehaviour {

    public GameObject portal;

    private void OnTriggerEnter(Collider other)
    {
        Transform otherTransform = other.gameObject.transform;
        if (other.gameObject.tag == "FakeObstacle")
        {
            GameObject newPortal = Instantiate(portal, new Vector3(this.transform.position.x, otherTransform.position.y, otherTransform.position.z), Quaternion.identity);
            MovingUp movingUpScr = newPortal.GetComponent<MovingUp>();
            MovingUp otherMovingUpScr = other.gameObject.GetComponent<MovingUp>();
            movingUpScr.speed = otherMovingUpScr.speed;
        }
            Destroy(gameObject);
    }
}
