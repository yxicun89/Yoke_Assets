using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{

    //�ϐ��錾

    float speed = 5.0f;


    // �Q�[���J�n����1�x����
    void Start()
    {
        
        
    }

    // �Q�[���������Ə���
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

    //�����蔻������m�������ɏ���
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("����������I");
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
