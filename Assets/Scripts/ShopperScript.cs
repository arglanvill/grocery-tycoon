using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopperScript : MonoBehaviour {

    SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;
        if (position.y < -6.8f) {
            position.y += 0.05f;
        }
        transform.position = position;

        // Set the layer based on inside or outside the door
        if (position.y < -9.5f)
        {
            // Outside
            sprite.sortingLayerName = "Top";
        } else
        {
            sprite.sortingLayerName = "Bottom";
        }
    }
}
