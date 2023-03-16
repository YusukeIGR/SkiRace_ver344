using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce3 : MonoBehaviour {
    
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
        //rb.AddRelativeTorque(new Vector3(0, hori, -hori) * 2000.0f);
        //rb.AddRelativeTorque(new Vector3(vert, 0, -vert) * 2000.0f);

        /*トルクを加える
        rb.AddTorque(torque, ForceMode.Acceleration);

        if (Input.GetKey (KeyCode.RightArrow)){
            torque = Vector3.back;
        } 
        if (Input.GetKey (KeyCode.LeftArrow)){
            torque = Vector3.forward;
        }
        */
        //if (Input.GetKey (KeyCode.DownArrow)){ 
        //    rb.AddForce(0,0,hori*addFrontLear);
        //}

        /*
        if(Input.GetKey("Horizontal")){
            rb.AddForce(hori*addFrontLear,0,0);
        }
        */
        //if(Input.GetKey("Vertical")){
        //    rb.AddForce(0,0,Input.GetAxis("Vertical")*addLeftRight);
        //}
        //if(Input.GetKey("Horizontal") && Input.GetKey("Vertical")){
        //    rb.AddForce(Input.GetAxis("Horizontal")*addFrontLear, 0,Input.GetAxis("Vertical")*addLeftRight);
        //}
        
        //rb.AddForce(hori*addFrontLear, 0,vert*addLeftRight);
    }

    }
