//戦車の球のステータス
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject effect;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider obj){
        if(obj.gameObject.tag != "Player"){
            // エフェクトの生成
            GameObject effects = Instantiate(effect) as GameObject;
            // 弾丸の位置を調整
            effects.transform.position = this.transform.position;
            Destroy(this.gameObject);
        }
        
    }

}
