using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mimaqueding : MonoBehaviour
{
    string str = "2856";
    public Text daantext;
    public GameObject jieti;

    public GameObject panel;//背包界面
    public GameObject button;//背包界面伸缩的按钮

    bool baoxiangui;

    // Start is called before the first frame update
    void Start()
    {
        baoxiangui = false;
        GameManager.queding = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void queding()
    {
        if (daantext.text == str)
        {
            //daantext.text = "恭喜你密码正确";
            baoxiangui = true;
            //jieti.SetActive(false);
            Destroy(jieti);
            //GameObject.Find("MainCamera").GetComponent(JianTing).enabled=true;
            
            GameManager.queding = true;
            
            button.SetActive(true);
            panel.SetActive(true);

            daantext.text = "";
        }
        else
        {
            daantext.text = "密码错误";
        }
    }
}
