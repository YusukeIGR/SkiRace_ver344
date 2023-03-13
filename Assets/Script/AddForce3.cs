using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce3 : MonoBehaviour {
    
    private Rigidbody _rigidbody;

    // 最大の回転角速度[deg/s]
    private float _maxAngularSpeed = Mathf.Infinity;

    // 進行方向に向くのにかかるおおよその時間[s]
    private float _smoothTime = 0.1f;

    private float _currentAngularVelocity;

    private Transform _transform;
    //private Vector3 latestPos;
    private Vector3 _prevPosition;

    public float charrotate=3;

    //接地判定
    public bool isJumping;

     public float addFrontLear=10;
        public float addLeftRight=10;

     private void Start()
    {
        _transform = transform;

        _prevPosition = _transform.position;
        
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

        // 現在フレームのワールド位置
        var position = _transform.position;

        // 移動量を計算
        var delta = position - _prevPosition;

        // 次のUpdateで使うための前フレーム位置更新
        _prevPosition = position;

        // 静止している状態"もしくは空中にいる間は"、進行方向を特定できないため回転しない
        if (delta == Vector3.zero || isJumping)
            return;

        // 進行方向（移動量ベクトル）に向くようなクォータニオンを取得
        var targetRot = Quaternion.LookRotation(delta, Vector3.up);

         // 現在の向きと進行方向との角度差を計算
        var diffAngle = Vector3.Angle(_transform.forward, delta);
        // 現在フレームで回転する角度の計算
        var rotAngle = Mathf.SmoothDampAngle(
            0,
            diffAngle,
            ref _currentAngularVelocity,
            _smoothTime,
            _maxAngularSpeed
        );

        // 現在フレームにおける回転を計算
        var nextRot = Quaternion.RotateTowards(
            _transform.rotation,
            targetRot,
            rotAngle
        );
        // オブジェクトの回転に反映
        if(rb.velocity.magnitude > charrotate){
        _transform.rotation = nextRot;
        }

        
    }
    
    public void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Stage")){
            isJumping = false;
        }
    }
    
    
  
}