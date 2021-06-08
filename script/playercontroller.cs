using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    [SerializeField]
    private GameObject Boll;
    [SerializeField]
    private GameObject BollPosition;

    Rigidbody rb;
    float accel = 1000.0f;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        rb.AddForce(transform.right * Input.GetAxis("Horizontal") * accel,ForceMode.Impulse);
        
    }
}
