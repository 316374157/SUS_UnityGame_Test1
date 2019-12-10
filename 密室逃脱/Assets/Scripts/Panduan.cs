using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Panduan : MonoBehaviour
{
    public GameObject pintu;
    public Transform tr;
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Denglu()
    {
        if (tr.GetChild(0).gameObject.GetComponent<Image>().color == Color.yellow)
        {
            if (tr.GetChild(1).gameObject.GetComponent<Image>().color == Color.green)
            {
                if (tr.GetChild(2).gameObject.GetComponent<Image>().color == Color.red)
                {
                    if (tr.GetChild(3).gameObject.GetComponent<Image>().color == Color.blue)
                    {
                        if (tr.GetChild(4).gameObject.GetComponent<Image>().color == Color.red)
                        {
                            if (tr.GetChild(5).gameObject.GetComponent<Image>().color == Color.green)
                            {
                                if (tr.GetChild(6).gameObject.GetComponent<Image>().color == Color.green)
                                {
                                    if (tr.GetChild(7).gameObject.GetComponent<Image>().color == Color.red)
                                    {
                                        if (tr.GetChild(8).gameObject.GetComponent<Image>().color == Color.yellow)
                                        {
                                            pintu.SetActive(false);
                                            win.SetActive(true);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public void Tuichu()
    {
        pintu.SetActive(false);
    }
}
