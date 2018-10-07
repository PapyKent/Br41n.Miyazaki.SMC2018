using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMov : MonoBehaviour {

    Vector3 referencePostion;
    public bool upNdown = true;
    bool positiveMov = false;
    public float movDistance = 2.0f;
    public float speed = 2;
    public Vector2 direction = new Vector2(0, 1);
 
    // Use this for initialization
    void Start () {
        referencePostion = this.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = new Vector3(0, 0);

        if (upNdown)
        {
            if (Mathf.Abs( referencePostion.y - this.transform.position.y) > movDistance)
                positiveMov = !positiveMov;

            if (positiveMov)
                direction.y = -1 * direction.y;

             movement = new Vector2(direction.x*speed, direction.y*speed);
        }
        else
        {

            movement = new Vector3(speed * direction.x, 0);
        }


        movement *= Time.deltaTime;
        transform.Translate(movement);
    }
}
