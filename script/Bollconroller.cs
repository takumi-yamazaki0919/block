using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll: MonoBehaviour
{

    [SerializeField]
    private float speed = 30.0f;
    Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce((transform.right + transform.forward) * speed,
            ForceMode.VelocityChange);
    }

    
}
