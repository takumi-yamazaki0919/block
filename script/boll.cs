using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bollcontroller: MonoBehaviour
{

    [SerializeField]
    private float speed = 20.0f;
    Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce((transform.right + transform.forward) * speed,
            ForceMode.VelocityChange);
    }

    
}
