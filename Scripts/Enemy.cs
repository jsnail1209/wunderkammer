using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // �÷��̾� �߰� ����
    public float findDistance = 8f;

    // �÷��̾� Ʈ������
    Transform player;

    public Wave wave;
    public Inventory inven;
    public AudioSource audioSource;

    void Start()
    {
        // �÷��̾��� Ʈ������ ������Ʈ �޾ƿ���
        player = GameObject.Find("Player").transform;
        wave.gameObject.SetActive(false);
    }

    //void Update()
    //{
    //    // ����, �÷��̾���� �Ÿ��� �׼� ���� ���� �̳���� Move ���·� ��ȯ�Ѵ�.
    //    if (Vector3.Distance(transform.position, player.position) <= findDistance)
    //    {
    //        Debug.Log("���� ��ȯ: Idle -> Move");
    //        if (inven.itemCnt == 4)
    //        {
    //            wave.gameObject.SetActive(true);
    //            audioSource.Play();
    //        }
    //    }
    //}

    //private void OnCollisionEnter(Collision collision) // ������ ȹ��
    //{
    //    if (collision.gameObject.name == "Player")
    //    {
    //        Debug.Log("�ȳ�");
    //        wave.gameObject.SetActive(true);
    //        audioSource.Play();

    //    }
    //        //if (inven.itemCnt == 4)
    //        //{
    //        //    wave.gameObject.SetActive(true);
    //        //    audioSource.Play();
    //        //}
    //        //else
    //        //{
    //        //    wave.gameObject.SetActive(false);
    //        //    audioSource.Stop();
    //        //}
    //}

    //private void OnTriggerEnter(Collider other) // ������ ȹ��
    //{
    //    if (other.gameObject.name == "Player")
    //    {
    //        wave.gameObject.SetActive(true);
    //    }
    //}

    void Update ()
    {
        if (inven.itemCnt == 4)
        {
            wave.gameObject.SetActive(true);
            if (Vector3.Distance(transform.position, player.position) >= findDistance)
            {
                Debug.Log("�ȳ�");
                audioSource.Play();
            }
        }
    }
}
