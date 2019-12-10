using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cli : MonoBehaviour
{
    public Transform tr;
    public GameObject ga;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click1()
    {
        for(int i = 0; i < tr.childCount; i++)
        {
            if(tr.GetChild(i).gameObject.activeSelf == true)
            {
                tr.GetChild(i).gameObject.SetActive(false);
            }
            ga.SetActive(false);
        }
    }
}
