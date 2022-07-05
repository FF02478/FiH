using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraMove : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        
        if(transform.position.y<playerPos.y)
            transform.position = new Vector3(
            transform.position.x, playerPos.y, transform.position.z);
        else
        {
            transform.position = new Vector3(
                transform.position.x, transform.position.y, transform.position.z);
        }
        
    }
}
