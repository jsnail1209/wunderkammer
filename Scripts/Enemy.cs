using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 플레이어 발견 범위
    public float findDistance = 8f;

    // 플레이어 트랜스폼
    Transform player;

    public Wave wave;
    public Inventory inven;
    public AudioSource audioSource;

    void Start()
    {
        // 플레이어의 트랜스폼 컴포넌트 받아오기
        player = GameObject.Find("Player").transform;
        wave.gameObject.SetActive(false);
    }

    //void Update()
    //{
    //    // 만일, 플레이어와의 거리가 액션 시작 범위 이내라면 Move 상태로 전환한다.
    //    if (Vector3.Distance(transform.position, player.position) <= findDistance)
    //    {
    //        Debug.Log("상태 전환: Idle -> Move");
    //        if (inven.itemCnt == 4)
    //        {
    //            wave.gameObject.SetActive(true);
    //            audioSource.Play();
    //        }
    //    }
    //}

    //private void OnCollisionEnter(Collision collision) // 아이템 획득
    //{
    //    if (collision.gameObject.name == "Player")
    //    {
    //        Debug.Log("안녕");
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

    //private void OnTriggerEnter(Collider other) // 아이템 획득
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
                Debug.Log("안녕");
                audioSource.Play();
            }
        }
    }
}
