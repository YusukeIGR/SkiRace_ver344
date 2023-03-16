using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce4 : MonoBehaviour {
    
    
    private Rigidbody _rigidbody;

    public float moveSpeed = 20f;

    public float y=-9.8f;
     
     
    //一秒間に一定の回数呼ばれる
    void FixedUpdate()
    {
        // 入力をxとzに代入
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
 
        //Rigidbodyを取得
        Rigidbody rb = GetComponent<Rigidbody>();

        
        
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = cameraForward * vert + Camera.main.transform.right * hori;

        //rb.velocity = moveForward+new Vector3(hori,0,vert)*10;
        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);
        //addfocerb.AddForce(hori*4, 0,vert*4);

        // キャラクターの向きを進行方向に
        if (moveForward != Vector3.zero) {
        transform.rotation = Quaternion.LookRotation(moveForward);
        }
    
    }
}
