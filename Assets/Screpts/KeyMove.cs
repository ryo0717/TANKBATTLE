//キー入力を受け付ける
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// //CapsuleColliderとRigidbodyを追加
// [RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Rigidbody))]

public class KeyMove : MonoBehaviour {
    
    public Vector3 movePos;

    //移動スピード
    float speed = 10f;
    //方向転換のスピード
    float angleSpeed = 50;

    //Rigidbodyを入れる
    Rigidbody rb;

    void Start()
    {
        //Rigidbodyコンポーネントを取得
        rb = GetComponent<Rigidbody>();
        //RigidbodyのConstraintsを3つともチェック入れて
        //勝手に回転しないようにする
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void Update()
    {
        //WSキー、↑↓キーで移動する
        float z = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;

        //前進の後退
        //後退は前進の3分の1のスピードになる
        if (z > 0)
        {
            transform.position += transform.forward * z;
        } else
        {
            transform.position += transform.forward * z / 3;
        }

        //ADキー、←→キーで方向を替える
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * angleSpeed;
        transform.Rotate(Vector3.up * x);
    }

}