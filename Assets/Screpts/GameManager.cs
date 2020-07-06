//ゲームマネージャー
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text countEnemy;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 8;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        SetCountText();
        if(count < 1){
            SceneManager.LoadScene ("Clear");
        }
    }
    void SetCountText(){
        countEnemy.text = count.ToString();
    }
    public void SetCount(){
        count -= 1;
    }
}
