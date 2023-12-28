using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//맴 세팅, 게임 매니저

public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase instance;
    private void Awake()
    {
        instance = this;
    }

    public List<Item> itemDB= new List<Item>();
    [Space(20)]
    public GameObject fieldItemPrefab;
    public GameObject ttem;
    public Vector3[] pos;
    public Inventory inven;

    private void Start()
    {
        inven = Inventory.instance;
        for (int i = 0; i < 4; i++)
        {
            GameObject go = Instantiate(fieldItemPrefab, pos[i], Quaternion.identity);
            go.GetComponent<tem>().SetItem(itemDB[i]);
        }
        //inven.SetItem(itemDB[2]);
        //inven.SetItem(itemDB[2]);
    }

}
