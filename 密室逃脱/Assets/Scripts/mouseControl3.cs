using UnityEngine;
using System.Collections;
 
public class mouseControl3 : MonoBehaviour {
    float org_x;
    //float time = 0.0f;
    bool mousedown = false;
    bool isrotate = false;
 
    // Use this for initialization
    void Start ()
    {
        org_x = transform.localEulerAngles.x;
    }
     
    // Update is called once per frame
    void Update () {
    
 
        if(mousedown && GameManager.queding == true)
        {
            if (!isrotate)
            {
                if (transform.localEulerAngles.x < 88)
                {
                    transform.Rotate(new Vector3(90,0,0)*Time.deltaTime);//
                }
                else
                {
                    isrotate = true; //已被旋转, 下次点击就回到原来位置.
                    mousedown = false; //停止
                }
            }
            else
            {
                if(transform.localEulerAngles.x < 350 && transform.localEulerAngles.x > 1.3)//(transform.localEulerAngles.x - org_x) < 360 &&
                {
                  transform.Rotate(new Vector3(-90,0,0)*Time.deltaTime);//
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
                //print(GameManager.st.Substring(0, 2) + transform.name.Substring(0, 2));
    }
    void OnMouseDown()
    {
        Click();
    }
}