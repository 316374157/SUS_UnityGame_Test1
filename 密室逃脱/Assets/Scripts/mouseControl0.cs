using UnityEngine;
using System.Collections;
 
public class mouseControl0 : MonoBehaviour {
    float org_y;
    //float time = 0.0f;
    bool mousedown = false;
    bool isrotate = false;
 
    // Use this for initialization
    void Start ()
    {
        org_y = transform.localEulerAngles.y;
    }
 
    // Update is called once per frame
    void Update () {
    
 
 
        if(mousedown)
        {
            if (!isrotate)
            {
                if (transform.localEulerAngles.y < 91)//
                {
                    transform.Rotate(new Vector3(0,90,0)*Time.deltaTime ,Space.World);
                }
                else
                {
                    isrotate = true; //已被旋转, 下次点击就回到原来位置.
                    mousedown = false; //停止
                }
            }
            else
            {
                if(transform.localEulerAngles.y > 180)// transform.localEulerAngles.y - org_y > 80 && 
                {
                    transform.Rotate(new Vector3(0,-90,0)*Time.deltaTime ,Space.World);
                    //回到原来位置 
                }
                else
                {
                    isrotate = false; //旋转复原
                    mousedown = false; //停止
                }
            }
        }
    }
    public void Click()
    {
        mousedown = true;
        // if (GameManager.st != null)
        // {
        //     if (GameManager.st.Substring(0, 2) == transform.name.Substring(0, 2))
        //     {
        //         mousedown = true;
        //         //print(GameManager.st.Substring(0, 2) + transform.name.Substring(0, 2));
        //     }
        // }

    }
    void OnMouseDown()
    {
        Click();
    }
}