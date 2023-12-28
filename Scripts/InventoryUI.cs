 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    InventoryUI ui;
    Inventory inven;
    public GameObject inventoryPanel;
    public bool activeInventory = false;

    public Slot[] slots;
    public Transform slotHolder;
    public GameObject collect;

    private void Start()
    {
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();
        //inven.onSlotCountChange += SlotChange;
        inven.onChangeItem += RedrawSlotUI;
        Debug.Log("±èÁø±Ô");
        inventoryPanel.SetActive(activeInventory);
        
        for(int i = 0; i < 4; i++)
        {
            slots[i].gameObject.SetActive(false);
        }
    }

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

    void RedrawSlotUI()
    {
        for (int i = 0; i < inven.items.Count; i++)
        {
            slots[i].gameObject.SetActive(true);
            slots[i].item = inven.items[i];
            slots[i].UpdateSlotUI();

        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (!activeInventory)
                CallMenu();
            else
                CloseMenu();
                //inven.items[inven.itemCnt-1].audioSource.Stop();
            //gameObject.GetComponent<ThirdPersonCam>().enabled = false;
        }

    }

    public void CallMenu()
    {
        activeInventory = true;
        inventoryPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void CloseMenu()
    {
        activeInventory = false;
        inventoryPanel.SetActive(false);
        Time.timeScale = 1f;
        //collect.gameObject.SetActive(false);
    }

    //public void addslot()
    //{
    //    inven.slotcnt++;
    //}



}
