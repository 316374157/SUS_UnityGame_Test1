using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EveryButtonClick : MonoBehaviour
{
    
    public Button BT;
    Image image;

    Image im;


    private void Awake()
    {
        image = BT.GetComponent<Image>();
        image.color = Color.white;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DianJi()
    {   
        //print(GameManager.liang);
        if (GameManager.liang == true)//如果true则先把上次选择的线索按钮恢复
        {
            im = GameManager.button[GameManager.xiansuo].GetComponent<Image>();
            im.color = Color.white;
        }
        for (int i = 0; i < 11; i++)
        {
            if (i == int.Parse(BT.name))
            {
                //print(GameManager.xiansuo);        
                GameManager.xiansuo = i;//记录当前选择的线索是哪个
                GameManager.liang = true;
                im = GameManager.button[GameManager.xiansuo].GetComponent<Image>();
                GameManager.st = im.sprite.name;
            }
            else
            {
                //GameManager.flag1[i] = false;              
            }
        }
        
        im = GameManager.button[GameManager.xiansuo].GetComponent<Image>();
        im.color = Color.yellow + Color.blue;//改当前选中的线索button的状态

       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
