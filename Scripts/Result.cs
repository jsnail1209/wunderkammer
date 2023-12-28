using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Result
{
    public static Result instance;
    public int index;
    public string itemName;
    public Sprite itemImage;
    public AudioSource audioSource;

    public bool Use()
    {
        return false;
    }

}
