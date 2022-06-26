using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumping : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    public float jumpForce = 350f;
    private bool doesCollideOnThisFrame;



    // Start is called before the first frame update
    private void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   private void Update()
    {
        if (doesCollideOnThisFrame)
        {
            this.rbody2D.AddForce(transform.up * jumpForce);
            this.doesCollideOnThisFrame = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.relativeVelocity);
        if (other.gameObject.CompareTag("Floor") && other.relativeVelocity.y >0)
        {
            this.doesCollideOnThisFrame = true;
        }
    }
}
