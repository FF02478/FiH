using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXMove : MonoBehaviour
{
    public float xForce;
    private Rigidbody2D rb ;

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
            this.rb.AddForce(Vector2.right*xForce);
        }
        else if (horizontalKey < 0)
        {
            this.rb.AddForce(Vector2.left*xForce);
        }
    }
}
