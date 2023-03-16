using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGRCharacterControl : MonoBehaviour
{
   private Rigidbody _rigidbody;
    Vector3 torque;

     public float addFrontLear=10;
     public float addLeftRight=10;

     public float rotationforce=1;
     

    void Start()
    {
        //Rigidbodyを取得
        //var rb = GetComponent<Rigidbody>();
 
        //isKinematicをオンにする
        //rb.isKinematic = true;
    } 
    //一秒間に一定の回数呼ばれる
    void FixedUpdate()
    {
        
        //Rigidbodyを取得
       Rigidbody rb = GetComponent<Rigidbody>();

       //rb.AddRelativeTorque(new Vector3(2000,2000,2000));
       //if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow)){
       //     rb.isKinematic = false;
       //}

       float hori = Input.GetAxis("Horizontal");
       float vert = Input.GetAxis("Vertical");

        if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow)){
            rb.AddRelativeForce(0,0,vert*addFrontLear);
        }
        if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow)){
            //rb.AddForce(hori*addLeftRight,0,0);
            rb.AddTorque(new Vector3(0,hori*addLeftRight*rotationforce,0));
        }
    }
}
