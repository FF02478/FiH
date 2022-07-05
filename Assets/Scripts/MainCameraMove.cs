using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraMove : MonoBehaviour
{
    GameObject mainCamera;
    private float cameraDestination;
    public float cameraSpeed;

    // Start is called before the first frame update
    void Start()
    {
        this.mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Transform mainCameraTransform = this.mainCamera.transform;

        if (cameraDestination > mainCameraTransform.position.y)
        {
            mainCameraTransform.position += Vector3.up * Time.deltaTime * cameraSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor") && other.relativeVelocity.y > 0)
        {
            this.cameraDestination = other.transform.position.y;
        }
    }
}