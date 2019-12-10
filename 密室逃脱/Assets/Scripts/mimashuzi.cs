using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mimashuzi : MonoBehaviour
{
    //public Transform transform;
    public Button button;//0到9的按钮
    public Text daantext;

    // Start is called before the first frame update
    void Start()
    {
        daantext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shuru()
    {
        if (GameManager.queding == true)
        {
            daantext.text = "";
        }
        daantext.text += button.name;
        GameManager.queding = false;
    }
}
