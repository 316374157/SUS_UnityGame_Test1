﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jiancha : MonoBehaviour
{

    public Transform transform;
    Image image;
    string st = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            image = transform.GetChild(i).gameObject.GetComponent<Image>();
            if (i > 0)
            {
                st = transform.GetChild(i - 1).gameObject.GetComponent<Image>().sprite.name;
                if (image.sprite.name == st)
                {
                    image.sprite = Resources.Load("moren", typeof(Sprite)) as Sprite;
                    GameManager.flag[i] = true;
                }
            }
        }
    }
}
