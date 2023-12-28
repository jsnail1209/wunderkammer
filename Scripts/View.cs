using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class View
{
    public static View instance;
    public Sprite guideImage;

    public bool Use()
    {
        return false;
    }

}
