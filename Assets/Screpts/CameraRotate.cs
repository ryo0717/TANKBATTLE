using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraRotate : MonoBehaviour {
    
    private GameObject player;       //プレイヤー格納用
    private Vector3 playerpos;
    float angleSpeed = 50;
 
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Tank");
        playerpos = player.transform.position;

	}
	
	// Update is called once per frame
    void Update () {
        transform.position += player.transform.position - playerpos;
        playerpos = player.transform.position;
        float x = Input.GetAxisRaw("Horizontal");
        // transform.Rotate(Vector3.up * x);
        transform.RotateAround(playerpos, Vector3.up, x * Time.deltaTime * angleSpeed);
	}
}



// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
 
// public class CameraRotate : MonoBehaviour {
 
//     //プレイヤーを変数に格納
//     public GameObject Player;
 
//     //回転させるスピード
//     public float rotateSpeed = 50.0f;
 
//     // Use this for initialization
//     void Start () {
         
//     }
     
//     // Update is called once per frame
//     void Update () {
 
//         //回転させる角度
//         float angle = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
 
//         //プレイヤー位置情報
//         Vector3 playerPos = Player.transform.position;
 
//         //カメラを回転させる
//         transform.RotateAround(playerPos, Vector3.up, angle);
//     }
// }