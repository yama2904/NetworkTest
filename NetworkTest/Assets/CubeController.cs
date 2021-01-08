using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CubeController : NetworkBehaviour
{
    [SerializeField] float speed = 0.03f;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (!isLocalPlayer) return;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(speed * -1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, speed * -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
    }
}
