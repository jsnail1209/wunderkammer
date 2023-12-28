using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Qwer : MonoBehaviour
{
    Qwer qwer;
    public Slot[] slota;
    public Item item;
    public Image itemIcon;
    public Text itemText;
    //public int index;

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
            //btn.GetComponent<Button>().interactable = true;
        }
    }

    private void Start()
    {
        //btn.GetComponent<Button>().interactable = false;
        inven = Inventory.instance;
        //slots = slotHolder.GetComponentsInChildren<CraftSlot>();
    }
}
