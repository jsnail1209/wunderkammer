using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftSlot : MonoBehaviour
{
    public Item item;
    public Image itemIcon;
    public Text itemText;
    public int index;
    public Craft craft;
    public Slot slot;
    public Button btna;

    Inventory inven;

    //public void UpdateSlotUI()
    //{
    //    itemIcon.sprite = item.itemImage;
    //    //itemText.text = item.itemText;
    //    index = item.index;
    //}

    public void button ()
    {
        itemIcon.sprite = null;
        if (itemIcon.sprite == null)
        {
            craft.index -= item.index;
            slot.itemIcon.sprite = item.itemImage;
            slot.btn.GetComponent<Button>().interactable = true;
            btna.GetComponent<Button>().interactable = false;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        inven = Inventory.instance;
        btna.GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
