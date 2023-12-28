using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 플레이어 컨트롤, 동적인 이벤트 처리

public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;
    private void Awake()
    {  
        if (instance == null)
        {
            instance = this;
            //Destroy(gameObject);
            //return;
        }
    }
    #endregion

    public delegate void OnSlotCountChange(int val);
    public OnSlotCountChange onSlotCountChange;

    public delegate void OnChangeItem();
    public OnChangeItem onChangeItem; 

    public List<Item> items = new List<Item>();

    public int itemCnt;
    public TextA texta;
    public Add add;
    public GameObject collect;

    public int SlotCnt
    {
        get => slotCnt;
        set
        {
            slotCnt = value;
            //onSlotCountChange.Invoke(slotCnt);
        }
    }
    public InventoryUI ui;

    private int slotCnt;
    private Item item;


    // Start is called before the first frame update
    void Start()
    {
        texta.gameObject.SetActive(false);
        collect.gameObject.SetActive(false);
        add.gameObject.SetActive(false);
        SlotCnt = 4;
        ui.activeInventory = false;
    }

    public bool AddItem(Item _item)  //인벤토리 추가
    {
        if(items.Count < SlotCnt)
        {
            items.Add(_item);
            if(onChangeItem != null)
            {
                onChangeItem.Invoke();
                return true;

            }

        }
        return false;
    }

    private void OnTriggerEnter (Collider collision) // 아이템 획득
    {
        if(collision.CompareTag("FieldItem"))
        {
            tem fieldItems = collision.GetComponent<tem>();
            if (AddItem(fieldItems.GetItem()))
            {
                itemCnt++;

                    if(itemCnt == 1)
                    {
                    fieldItems.DestroyItem();
                    ui.CallMenu();
                    items[0].audioSource.Play();
 
                    }

                    if (itemCnt == 2)
                    {
                        items[1].audioSource.Play();
                        fieldItems.DestroyItem();
                        ui.CallMenu();

                    }

                    if (itemCnt == 3)
                    {
                        items[2].audioSource.Play();
                        fieldItems.DestroyItem();
                        ui.CallMenu();

                    }

                    if (itemCnt == 4)
                    {
                        items[3].audioSource.Play();
                        fieldItems.DestroyItem();
                        ui.CallMenu();

                    }
                texta.gameObject.SetActive(true);
            }

        }
    }


    // Update is called once per frame
    void Update()
    {
        if (ui.activeInventory == false)
        {
            for(int i = 0; i < items.Count; i++)
            {
                items[i].audioSource.Stop();
                ui.CloseMenu();
            }

        }

        if (itemCnt == 4)
        {
            Debug.Log("수집완료");
            collect.gameObject.SetActive(true);
            if (ui.activeInventory == false)
            {
                collect.gameObject.SetActive(false);
            }

            //add.gameObject.SetActive(true);
        }

 
        
    }
}
