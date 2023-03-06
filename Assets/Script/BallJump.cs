using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BallJump : MonoBehaviour
{
    public float jumpPower;
    public float frontPower;
    private Rigidbody rb;
    private bool isJumping = false; 
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& ! isJumping)
        {
            rb.AddForce(0,jumpPower,frontPower);
            isJumping = true;
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Stage")){
            isJumping = false;
        }
    }
}