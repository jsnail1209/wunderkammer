using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add : MonoBehaviour
{
    bool act = false;
    public Add add;
    public Item item;
    public Image itemIcon;
    public Text itemText;
    //public int index;

    public Slot[] slots;
    public CraftSlot slotss;
    public Craft craft;
    Inventory inven;
    public Transform slotHolder;

    public List<Result> results = new List<Result>();
    public Result result;

    public delegate void OnChangeItem();
    public OnChangeItem onChangeItem;

    private void SlotChange(int val)
    {
        for (int i = 4; i < slots.Length; i++)
        {
            if (i < inven.SlotCnt)
                slots[i].GetComponent<Button>().interactable = true;
            else
                slots[i].GetComponent<Button>().interactable = false;
        }
    }

    //public void UpdateSlotUI()
    //{
    //    itemIcon.sprite = item.itemImage;
    //    itemText.text = item.itemText;
    //    //index = item.index;
    //    //itemIcon.gameObject.SetActive(true);
    //    //itemText.gameObject.SetActive(true);
    //}

    public void Button()
    {
        add.result = craft.result;

        if (!act)
        {
            act = true;
            add.result.audioSource.Play();
        } else
        {
            act = false;
            add.result.audioSource.Stop();
        }

        //itemIcon.sprite = item.itemImage;
        //slotss.item = item;
        //slotss.itemIcon.sprite = item.itemImage;
        ////slotss.index = item.index;
        //craft.items.Add(item);
        //craft.index += item.index;

    }

    private void Start()
    {
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();


        //inven.onSlotCountChange += SlotChange;
        //inven.onChangeItem += RedrawSlotUI;
    }

    //void RedrawSlotUI()
    //{
    //    for (int i = 0; i < inven.items.Count; i++)
    //    {
    //        slots[i].item = inven.items[i];
    //        slots[i].UpdateSlotUI();

    //    }
    //}

    //public void RemoveSlot()
    //{
    //    item = null;
    //    itemIcon.gameObject.SetActive(false);
    //    itemText.gameObject.SetActive(false);
    //}
}
