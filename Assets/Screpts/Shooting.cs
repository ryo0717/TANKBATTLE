using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Shooting : MonoBehaviour {
 
    // bullet prefab
    public GameObject bullet;
 
    // 弾丸発射点
    public Transform muzzle;

    public AudioClip sound;

    AudioSource audioSource;
 
    // 弾丸の速度
    public float speed = 1000;
    public int B_count = 0 ;
 
	// Use this for initialization
	void Start () {
		   //Componentを取得
            audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if(B_count > 0){
            B_count -= 1;
        }

        if(B_count == 0){
                // space キーが押された時
            if (Input.GetKeyDown(KeyCode.Space)){

                audioSource.PlayOneShot(sound);
                
                // 弾丸の複製
                GameObject bullets = Instantiate(bullet) as GameObject;
    
                Vector3 force;
    
                force = this.gameObject.transform.forward * speed;

                bullets.transform.rotation = this.transform.rotation;
    
                // Rigidbodyに力を加えて発射
                bullets.GetComponent<Rigidbody>().AddForce(force);
    
                // 弾丸の位置を調整
                bullets.transform.position = muzzle.position;

                B_count += 100;
            }
        }
        
        //Debug.Log(B_count);
		
	}
}