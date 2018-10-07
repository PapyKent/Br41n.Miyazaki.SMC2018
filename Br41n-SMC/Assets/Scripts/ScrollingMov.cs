using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingMov : MonoBehaviour {

    /// <summary>
    /// Scrolling speed
    /// </summary>
    public Vector2 speed = new Vector2(2, 2);

    /// <summary>
    /// Moving direction
    /// </summary>
    public Vector2 direction = new Vector2(-1, 0);

    /// <summary>
    /// Movement should be applied to camera
    /// </summary>
    public bool isLinkedToCamera = false;

    public int distToCam = 10;
        

    void Update()
    {
        // Movement
        Vector3 movement = new Vector3(
          speed.x * direction.x,
          speed.y * direction.y,
          0);

        movement *= Time.deltaTime;
        transform.Translate(movement);

        // Move the camera
        if (isLinkedToCamera)
        {
            Camera.main.transform.Translate(movement);
        }

        //respawn
        if (this.GetComponent<Transform>().position.x < -distToCam)
        {
            float yBias = Random.Range(-1, 5);
            float xBias = Random.Range(-5, 5);
            this.GetComponent<Transform>().position = new Vector2 (Camera.main.transform.position.x * -1 + xBias + distToCam,  yBias);
        }
    }
}

