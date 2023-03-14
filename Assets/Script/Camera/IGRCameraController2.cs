using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGRCameraController2 : MonoBehaviour
{
float inputHorizontal;
float inputVertical;

GameObject targetObj;
Vector3 targetPos;
 
void Start () {
   
    targetObj = GameObject.Find("A");
   
    targetPos = targetObj.transform.position;
}
 
void Update() {
    // targetの移動量分、自分（カメラ）も移動する
    transform.position += targetObj.transform.position - targetPos;
    targetPos = targetObj.transform.position;
 
        // マウスの移動量
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        // targetの位置のY軸を中心に、回転（公転）する
        transform.RotateAround(targetPos, Vector3.up, inputHorizontal * Time.deltaTime * 200f);
        // カメラの垂直移動（※角度制限なし、必要が無ければコメントアウト）
        transform.RotateAround(targetPos, transform.right,inputVertical * Time.deltaTime * 200f);
    
}   
}
