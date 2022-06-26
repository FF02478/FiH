using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    public float worldPositionXRightEdge;
    public float worldPositionXLeftEdge;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > worldPositionXRightEdge)
        {
            transform.position = new Vector3(worldPositionXLeftEdge, transform.position.y, 0);
        }
        else if (transform.position.x < worldPositionXLeftEdge)
        {
            transform.position = new Vector3(worldPositionXRightEdge, transform.position.y, 0);
        }
    }
}
