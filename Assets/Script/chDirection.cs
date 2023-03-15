using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chDirection : MonoBehaviour
{
    public float frictionLine=0.01f;
    bool isJumping;
    private Vector3 latestPos;  //前回のPosition
    
    void start(){
        isJumping=true;
    }
    void Update()
    {
        Vector3 diff = transform.position - latestPos;   //前回からどこに進んだかをベクトルで取得
        latestPos = transform.position;  //前回のPositionの更新
        Rigidbody rb = GetComponent<Rigidbody>();

        //ベクトルの大きさが0.01以上の時に向きを変える処理をする
        if (diff.magnitude > frictionLine && isJumping==false)
        {
            //transform.rotation = Quaternion.LookRotation(diff); //向きを変更する
            //rb.AddTorque(new Vector3(0,0,0));
        }   
    }
    public void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Stage")){
            isJumping = false;
        }
    }
}
