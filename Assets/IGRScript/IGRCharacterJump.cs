using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGRCharacterJump : MonoBehaviour
{
    public float jumpPower=200;
    public float frontPower=200;
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
            rb.AddRelativeForce(0,jumpPower,frontPower);
            isJumping = true;
        }
    }

    public void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Stage")){
            isJumping = false;
        }
    }
}
