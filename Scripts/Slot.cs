using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Slot slot;
    public Slot[] slota;
    public Item item;
    public Image itemIcon;
    public Text itemText;
    //public int index;

    public CraftSlot[] slots;
    public CraftSlot slotss;
    public Craft craft;
    Inventory inven;
    public Transform slotHolder;
    public Button btn;

    public delegate void OnChangeItem();
    public OnChangeItem onChangeItem;

    //private void SlotChange(int val)
    //{
    //    for (int i = 0; i < slots.Length; i++)
    //    {
    //        if (i < inven.SlotCnt)  
    //            slots[i].GetComponent<Button>().interactable = true;
    //        else
    //            slots[i].GetComponent<Button>().interactable = false;
    //    }
    //}

    public void UpdateSlotUI()
    {
        if (itemIcon.sprite != null)
        {
            itemIcon.sprite = item.itemImage;
            itemText.text = item.itemText;
            btn.GetComponent<Button>().interactable = true;
        } 

        //index = item.index;
        //itemIcon.gameObject.SetActive(true);
        //itemText.gameObject.SetActive(true);
    }

    public void Button()
    {
        //btn.GetComponent<Button>().interactable = true;
        slotss.item = item;
        slotss.itemIcon.sprite = item.itemImage;
        //slotss.index = item.index;
        craft.items.Add(item);

        //if (itemIcon.sprite != null)
        //{
        //    craft.index += item.index;
        //    btn.GetComponent<Button>().interactable = false;
        //    slotss.btna.GetComponent<Button>().interactable = true;
        //    itemIcon.sprite = null;
        //    itemText.text = null;
        //}

        //for (int i = 0; i < slota.Length; i++)
        //{
        //    slota[i].RemoveSlot();
        //}


    }

    private void Start()
    {
        btn.GetComponent<Button>().interactable = false;
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<CraftSlot>();
        //btn.GetComponent<Button>().interactable = false;

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
