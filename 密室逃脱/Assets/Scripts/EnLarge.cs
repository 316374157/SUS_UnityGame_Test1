using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnLarge : MonoBehaviour
{

    public Camera Camera01;

    Vector2 oldL;  //老的记录左手指的坐标
    Vector2 oldR;  //老的记录右手指的坐标

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 2) //两根手指
        {
            if(Input.GetTouch(0).phase == TouchPhase.Moved  || Input.GetTouch(1).phase == TouchPhase.Moved)
            {
                Vector2 nL = Input.GetTouch(0).position;  //新的记录左手指的坐标
                Vector2 nR = Input.GetTouch(1).position;  //新的记录右手指的坐标
                if (isEnLarge(oldL, nL, oldR, nR))  //放大
                {
                    //物体放大缩小，但是不适合这里使用
                    /*float oldScale = transform.localScale.x;  //以x轴为中心放大
                    float newScale = oldScale * 1.025f;  //放大倍数

                    transform.localScale = new Vector3(newScale, newScale, newScale);*/
                    //这里用调整摄像机的视野大小
                    if (Camera01.fieldOfView >= 30)
                        Camera01.fieldOfView -= 2;
                }
                else  //缩小
                {
                    /*float oldScale = transform.localScale.x;
                    float newScale = oldScale / 1.025f;

                    transform.localScale = new Vector3(newScale, newScale, newScale);*/
                    if (Camera01.fieldOfView <= 60)
                        Camera01.fieldOfView += 2;
                }
                oldL = nL;
                oldR = nR;
            }
        }
    }

    private bool isEnLarge(Vector2 xL,Vector2 xR,Vector2 yL,Vector2 yR)  //X是原来的，Y是新的
    {
        float old = Mathf.Sqrt((xL.x - yL.x) * (xL.x - yL.x) + (xL.y - yL.y) * (xL.y - yL.y)); //原来的向量
        float n = Mathf.Sqrt((xR.x - yR.x) * (xR.x - yR.x) + (xR.y - yR.y) * (xR.y - yR.y)); //现在的

        if (old > n) //缩小
        {
            return false;
        }
        else //放大
        {
            return true;
        }
    }
}
