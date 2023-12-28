using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    Equipment,
    Consumables,
    Etc
}

[System.Serializable]
public class Item
{
    public static Item instance;
    public int index;
    public ItemType itemType;
    public string itemName;
    public Sprite itemImage;
    public Mesh mesh;
    public string itemText;
    public AudioSource audioSource;

    public bool Use()
    {
        return false;
    }

}
