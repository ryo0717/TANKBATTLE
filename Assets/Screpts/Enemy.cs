//敵戦車のステータス
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float HP;
    public GameObject GM;
    public GameObject effect;
    private GameObject effects;
    GameManager script;
    Vector3 Eff_pos;

    public AudioClip sound1;
 
    AudioSource audioSource;
    
    private int count_eff=0;
    // Start is called before the first frame update
    void Start()
    {
        HP = 0;
        GM = GameObject.Find ("GameManager");
        script = GM.GetComponent<GameManager>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Eff_pos = this.transform.position;
        
        if(HP < 0){
            
            audioSource.PlayOneShot(sound1);
            if(count_eff == 0) createEff();
            script.SetCount();
            Destroy(this.gameObject);
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
