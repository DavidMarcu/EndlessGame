using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePortal : MonoBehaviour {

    public GameObject portal;
    public GameObject exitPortal;

    private float gapBetweenPortalAndObject = 0.1f;

    private void OnTriggerEnter(Collider other)
    {
        Transform otherTransform = other.gameObject.transform;

        if(other.gameObject.tag != "Obstacle")
        {
            Destroy(gameObject);
        }
        else
        {
            float portalYPosition = otherTransform.position.y + otherTransform.localScale.y / 2 + portal.transform.localScale.y + gapBetweenPortalAndObject;
            float exitPortalYPosition = otherTransform.position.y - otherTransform.localScale.y / 2 - portal.transform.localScale.y - gapBetweenPortalAndObject;

            Instantiate(portal, new Vector3(this.transform.position.x, portalYPosition, otherTransform.position.z), Quaternion.identity);
            Instantiate(exitPortal, new Vector3(this.transform.position.x, exitPortalYPosition, otherTransform.position.z), Quaternion.identity);

        }
    }
}
