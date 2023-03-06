using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BallJump : MonoBehaviour
{
    public float jumpPower;
    public float frontPower;
    private Rigidbody rb;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0,jumpPower,frontPower);
        }
    }
}