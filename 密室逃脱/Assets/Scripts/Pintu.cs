using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pintu : MonoBehaviour
{
    int i = 0;
    public Image im;
    private Image image;

    private void Start()
    {
        image = im.GetComponent<Image>();
    }

    public void Click()
    {
        if(i == 4)
        {
            i = 0;
        }
        switch (i)
        {
            case 0:
                image.color = Color.red;
                break;
            case 1:
                image.color = Color.yellow;
                break;
            case 2:
                image.color = Color.blue;
                break;
            case 3:
                image.color = Color.green;
                break;
        }
        i++;
    }

}
