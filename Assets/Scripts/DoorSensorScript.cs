using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    // Range of this sensor
    public float range = 1;
    public GameObject shopper;
    public bool detected = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        detected = SenseShopper();
	}

    // Determine if the shopper is within sensor range
    bool SenseShopper() {
        if (shopper == null)
            return false;
        Vector3 a = transform.position;
        Vector3 b = shopper.GetComponent<Transform>().position;

        return (Vector3.Distance(a,b) < range);
    }

}
