using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
    //加到线索book上

    public GameObject bookchildrenimage;//book下面的Image
    Image im;       //book下的image的
    public Text booktext;//book下面的介绍

    public GameObject bookpanel;//book的UI界面

    Image image;   //当前选择背包中线索的

    public GameObject panel;//背包系统
    public GameObject button;//控制背包系统进出的按钮

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void book()
    {
        im = bookchildrenimage.GetComponent<Image>();
        image = GameManager.button[GameManager.xiansuo].GetComponent<Image>();
        bookpanel.SetActive(true);//为了可以点击出现和再次出现

        panel.SetActive(false);
        button.SetActive(false);//在jixu的代码中恢复true;
        if (GameManager.st != null)
        {
            if (image.sprite.name == "墨水")
            {
                im.sprite = Resources.Load("书字", typeof(Sprite)) as Sprite;
                booktext.text = "这个答案好像一串密码";
            }
        }
             
    }
    private void OnMouseDown()
    {
        book();
    }

}
