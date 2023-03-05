using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AddForce : MonoBehaviour {
    //private Vector3 latestPos; 
    //一秒間に一定の回数呼ばれる
    void FixedUpdate()
    {
        // 入力をxとzに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
 
        //Rigidbodyを取得
        Rigidbody rb = GetComponent<Rigidbody>();
 
        //Rigidbodyに力を加える
        rb.AddForce(x, 0,z);

        /*変更点
        Vector3 diff = transform.position - latestPos;   //前回からどこに進んだかをベクトルで取得
        latestPos = transform.position;  //前回のPositionの更新

        //ベクトルの大きさが0.01以上の時に向きを変える処理をする
        if (diff.magnitude > 0.01f)
        {
        transform.rotation = Quaternion.LookRotation(diff); //向きを変更する
        }
        */
        transform.Rotate(0,x,z); //向きを変更する
        
    }
}