using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    public GameObject game;
    Vector3 v = new Vector3();
    bool isUp = false;
    // Start is called before the first frame update
    void Start()
    {
        v = game.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        if(isUp == false)
        {
            game.transform.Translate(new Vector3(0, 0.2f, 0));
            isUp = true;
        }
        else
        {
            isUp = false;
            game.transform.position = v;
        }
    }

    void OnMouseDown()
    {
        Click();
    }
}
