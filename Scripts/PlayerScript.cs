using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{

    //変数宣言

    float speed = 5.0f;


    // ゲーム開始時に1度処理
    void Start()
    {
        
        
    }

    // ゲーム中ずっと処理
    void Update()
    {
        if (Input.GetKey("up")==true)
        {
            this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("down") == true)
        {
            this.transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("right") == true)
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("left") == true)
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }


    }

    //当たり判定を検知した時に処理
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("当たったよ！");
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
