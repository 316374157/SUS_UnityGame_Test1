using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZhengRen : MonoBehaviour
{
    //加到苹果上

    public GameObject gopanel;//jixugo的panel页面

    public GameObject panel;//背包系统
    public GameObject button;//控制背包系统进出的按钮

    Image image;   //当前选择背包中线索的

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void jixugo()
    {
        print("***");
        image = GameManager.button[GameManager.xiansuo].GetComponent<Image>();
        if (image.sprite.name == "刀")
        {
            gopanel.SetActive(true);
            panel.SetActive(false);
            button.SetActive(false);//在jixu中再出现
        }       
    }
    private void OnMouseDown() {
        jixugo();
    }
}
