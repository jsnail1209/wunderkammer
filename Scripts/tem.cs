using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tem : MonoBehaviour
{
    // �÷��̾� �߰� ����
    public float findDistance = 20f;

    // �÷��̾� Ʈ������
    Transform player;

    public GameObject btn;

    public Item item;
    public MeshFilter itemObj;

    public void SetItem(Item _item)
    {
        item.index = _item.index;
        item.itemName = _item.itemName;
        item.itemImage = _item.itemImage;
        item.itemType = _item.itemType;
        item.itemText = _item.itemText;
        item.audioSource = _item.audioSource;

        itemObj.sharedMesh =_item.mesh;

    }

    public Item GetItem()
    {
        return item;
    }

    public void DestroyItem()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        // �÷��̾��� Ʈ������ ������Ʈ �޾ƿ���
        //player = GameObject.Find("Player").transform;

        //btn = GameObject.Find("Button");

        //btn.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //if (Vector3.Distance(transform.position, player.position) < findDistance)
        //{
        //    Debug.Log("�÷��̾� �߰�");
        //    btn.SetActive(true);

        //} else
        //{
        //    btn.SetActive(false);
        //}


    }
}
