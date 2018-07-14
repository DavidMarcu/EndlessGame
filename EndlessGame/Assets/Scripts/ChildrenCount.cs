using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildrenCount : MonoBehaviour {

	void Update () {
		if(transform.childCount == 0)
        {
            Destroy(this.gameObject);
        }
	}
}
