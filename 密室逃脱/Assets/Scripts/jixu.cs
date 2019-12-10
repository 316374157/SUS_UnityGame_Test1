using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jixu : MonoBehaviour
{
    //加到线索book上 或者苹果上

    public GameObject UI;//book的UIpanel 或者 jixugo那个UI panel

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

    public void click()
    {
        panel.SetActive(true);
        button.SetActive(true);

        UI.SetActive(false);
    }
}
