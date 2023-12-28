using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewControl : MonoBehaviour
{
    public List<View> viewDB = new List<View>();
    public Image guideIcon;
    public View view;
    public GameObject previous;
    public GameObject ext;
    public GameObject Button;
    public GameObject Text;
    public int a;

    public void Next()
    {
        a += 1;
        guideIcon.sprite = viewDB[a].guideImage;
    }

    public void Previous()
    {
        a -= 1;
        guideIcon.sprite = viewDB[a].guideImage;
    }



    void Start()
    {
        a = 0;
        previous.gameObject.SetActive(false);
        Button.gameObject.SetActive(false);
        Text.gameObject.SetActive(false);
    }

    void Update()
    {
        if (a > 0)
        {
            previous.gameObject.SetActive(true);
            Button.gameObject.SetActive(true);
            Text.gameObject.SetActive(true);

            if (a == 1)
            {
                ext.gameObject.SetActive(false);
            }
        } 
        else
        {
            previous.gameObject.SetActive(false);
            ext.gameObject.SetActive(true);
        }
    }
}
