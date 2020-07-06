//ビルのステータス
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    private float HP;

    public GameObject effect;
    private GameObject effects;
    Vector3 Eff_pos;

    private int count_eff=0;

    
    // Start is called before the first frame update
    void Start()
    {
        Eff_pos = this.transform.position;
        Eff_pos.y += 8.0f;
        HP = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = this.transform.position;
        if(HP < 0){

            if(count_eff == 0) createEff();
           
            pos.y -= 0.2f;
            this.transform.position = pos;

            if(this.transform.position.y <-100){
                Destroy(this.gameObject);
                Destroy(effects.gameObject);
            }
        }
    }

    void OnTriggerEnter(Collider obj){
        if(obj.gameObject.tag == "Bullet"){
            HP -= 1;
        }
    }

    void createEff(){
        // エフェクトの生成
            effects = Instantiate(effect) as GameObject;
            effects.transform.position = Eff_pos;
            count_eff += 1;
    }
}
