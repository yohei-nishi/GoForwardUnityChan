using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //�L���[�u�̈ړ����x
    private float speed = -12;

    //���ňʒu
    private float deadLine = -10;

    // AudioSource�i�ۑ�j
    private AudioSource audioSource;

    // SE������ꏊ�i�ۑ�j
    public AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        // �R���|�[�l���g���擾�i�ۑ�j
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //�L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        { 
            Destroy(gameObject);
        }
    }

    //�ڐG���ɌĂяo�������i�ۑ�j
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // collision�̃^�O��F��
        if (collision.gameObject.tag == "CubeTag" || collision.gameObject.tag == "GroundTag")
        {
            //�@SE�����Đ�����
            audioSource.PlayOneShot(se);
        }
    }
}
