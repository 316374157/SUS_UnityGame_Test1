using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject BT;  //按钮
    Image image;  //按钮的图片

    public GameObject Ck;  //查看背景
    public Transform Ck1;  //查看系

    private GameObject Xx;

    private float time;  //时间记录
    bool isDown = false; //是否按下

    //按下
    public void OnPointerDown(PointerEventData eventData)
    {
        //GameManager.flag1[int.Parse(BT.name)] = true;
        time = Time.time;
        isDown = true;
    }

    //抬起
    public void OnPointerUp(PointerEventData eventData)
    {
        time = 0;
        isDown = false;


        Ck.SetActive(false);
        if (Xx != null)
            Xx.SetActive(false);
    }

    private void Awake()
    {
        image = BT.GetComponent<Image>(); //获取组件
    }

    // Update is called once per frame
    void Update()
    {
        if(image.sprite.name!="UISprite")
        {
            //长按显示信息
            if (Time.time - time > 0.15 && isDown == true)
            {
                Ck.SetActive(true);
                for (int i = 0; i < Ck1.childCount; i++)
                {
                    if ((Ck1.GetChild(i).name == image.sprite.name))  //信息一致
                    {
                        Xx = Ck1.GetChild(i).gameObject;
                        Xx.SetActive(true); //显示信息
                                            //aXx.GetComponent<Image>().sprite = Resources.Load(image.sprite.name, typeof(Sprite)) as Sprite;
                    }
                }
            }
        }
    }
}
