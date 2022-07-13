using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXMove2 : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb = null;
    float xSpeed = 0.0f; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalKey = Input.GetAxis("Horizontal");
       
        if (horizontalKey > 0)
        {
            xSpeed = speed;
        }
        else if (horizontalKey < 0)
        {
            xSpeed = -speed;
        }
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);
    }
}
