using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class jietichuxian : MonoBehaviour
{
    public GameObject men;
    public GameObject jieti;

    public GameObject panel;//背包界面
    public GameObject button;//背包界面伸缩的按钮

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void chuxian()
    {
        jieti.SetActive(true);
        panel.SetActive(false);
        button.SetActive(false);

        //GameObject.Find("MainCamera").GetComponent(JianTing).enabled=false;
    }
    private void OnMouseDown()
    {
        chuxian();
    }
}
