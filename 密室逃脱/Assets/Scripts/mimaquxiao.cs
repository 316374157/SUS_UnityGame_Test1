using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mimaquxiao : MonoBehaviour
{
    public GameObject jieti;
    public Text daantext;

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
    public void quxiao()
    {
        jieti.SetActive(false);
        daantext.text = "";

        button.SetActive(true);
        panel.SetActive(true);

    }
}
