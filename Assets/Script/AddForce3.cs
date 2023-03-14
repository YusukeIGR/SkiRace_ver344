using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce3 : MonoBehaviour {
    
    private Rigidbody _rigidbody;

    //接地判定
    public bool isJumping;

     public float addFrontLear=10;
     public float addLeftRight=10;

     private void Start()
    {
        isJumping = true;
    } 
    //一秒間に一定の回数呼ばれる
    void FixedUpdate()
    {
        // 入力をxとzに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
 
        //Rigidbodyを取得
        Rigidbody rb = GetComponent<Rigidbody>();

       
        
        //Rigidbodyに力を加える
        rb.AddForce(x*addFrontLear, 0,z*addLeftRight);

    }
    
    public void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Stage")){
            isJumping = false;
        }
    }
    
    
  
}