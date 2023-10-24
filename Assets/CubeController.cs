using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    // AudioSource（課題）
    private AudioSource audioSource;

    // SEを入れる場所（課題）
    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        // コンポーネントを取得（課題）
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        { 
            Destroy(gameObject);
        }
    }

    //接触時に呼び出す処理（課題）
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // collisionのタグを認識
        if (collision.gameObject.tag == "CubeTag" || collision.gameObject.tag == "GroundTag")
        {
            //　SEを一回再生する
            audioSource.PlayOneShot(se);
        }
    }
}
