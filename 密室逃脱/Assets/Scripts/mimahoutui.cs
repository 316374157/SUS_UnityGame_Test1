using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mimahoutui : MonoBehaviour
{
    public Text daantext;
    string str;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void houtui()
    {
        str = daantext.text;
        if (str.Length >1)
        {
            str = str.Substring(0, str.Length - 1);
            daantext.text = str;
        }
        else
        {
            daantext.text = "";
        }
    }
}
