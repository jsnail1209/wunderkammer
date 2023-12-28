using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 플레이어 컨트롤, 동적인 이벤트 처리

public class Craft : MonoBehaviour
{
    Inventory inven;
    public Item item;
    public Result result;
    public Image itemIcon;
    public Craft craft;

    public List<Item> items = new List<Item>();
    public List<Result> results = new List<Result>();
    public int index;

    //public void SetItem(Item _item)
    //{
    //    item.index = _item.index;

    //}

    //public Item GetItem()
    //{
    //    return item;
    //}

    private void Start()
    {
        inven = Inventory.instance;

   
        //inven.onSlotCountChange += SlotChange;
        //inven.onChangeItem += RedrawSlotUI;
    }

    public void Button()
    {
        if (index == 1)
        {
            Debug.Log("1");
        }

        if (index == 10)
        {
            Debug.Log("2");
        }

        if (index == 100)
        {
            Debug.Log("3");
        }

        if (index == 1000)
        {
            Debug.Log("4");
        }

        if (index == 11)
        {
            Debug.Log("5");
        }

        if (index == 101)
        {
            Debug.Log("6");
        }

        if (index == 1001)
        {
            Debug.Log("7");
        }

        if (index == 110)
        {
            Debug.Log("8");
        }

        if (index == 1010)
        {
            Debug.Log("9");
        }

        if (index == 1100)
        {
            Debug.Log("10");
        }

        if (index == 111)
        {
            Debug.Log("11");
        }

        if (index == 1011)
        {
            Debug.Log("12");
        }

        if (index == 1101)
        {
            Debug.Log("13");
        }

        if (index == 1110)
        {
            Debug.Log("14");
            itemIcon.sprite = results[13].itemImage;
            results[13].audioSource.Play();
        }

        if (index == 1111)
        {
            Debug.Log("15");
            //result = results[14];
            ////items.Add(result);
            itemIcon.sprite = results[14].itemImage;
            result.index = 14; 
            result.audioSource = results[14].audioSource;

            //results[14].audioSource.Play();

        }

    }

    private void Update()
    {

    }
}
