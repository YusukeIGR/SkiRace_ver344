using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterControl : MonoBehaviour
{
    public var AddVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void FixedUpdate()
    {
         // 前進
        if (keyW)
        {
            AddVector = transform.right * AccelSpeed;               // 正面のベクトル取得
            AddVector = new Vector3(AddVector.x, 0f, AddVector.z);  // 上下に行かないよう制御
            rb.AddForce(AddVector.x, AddVector.y, AddVector.z, ForceMode.Acceleration);
        }
        // 後退
        if (keyS) {
            AddVector = -transform.right * AccelSpeed;               // 正面のベクトル取得
            AddVector = new Vector3(AddVector.x, 0f, AddVector.z);  // 上下に行かないよう制御
            rb.AddForce(AddVector.x, AddVector.y, AddVector.z, ForceMode.Acceleration);
        }
        // 左回転
        if (keyA)
        {
            // テスト
            HAngle -= RotateSpeed;
        }
        // 右回転
        if (keyD)
        {
            // テスト
            HAngle += RotateSpeed;
        }
        //あたり判定
        CollisionFunc();
    }
    //当たり判定関数
    void CollisionFunc()
    {
        RaycastHit hit;
        Vector3 vec;
        Vector3 PositionDown = trans.up;
        // スライダの真下の座標を格納
        PositionDown.y =  -1f * 10;
        // 線分を飛ばす(時機真下へ)
        if (Physics.Raycast(trans.position, PositionDown, out hit, 50, mask.value))
        {
            // 当たった座標を代入
            vec = hit.point;
            // 面の法線取得+面から垂直に少し上げる
            vec.y = hit.point.y+0.1f;
            //cubeの座標書き換え
            qube.transform.position = hit.point;
            // 再配置
            rb.MovePosition(vec);
            // 面に対し垂直にスライダの向きを変える   
            axis = Quaternion.FromToRotation(Vector3.up, hit.normal);
            rb.MoveRotation(axis);
            // rb.MoveRotation(Quaternion.FromToRotation(Vector3.up, rb.transform.eulerAngles));
        } else {
            //Debug.Log("NO_Ground");
        }
        // 更に左右の操作を反映      
        rb.MoveRotation(Quaternion.AngleAxis(HAngle, trans.up));
}
