using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Changan : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject ga;  //第一个游戏物体，记录需要移动的物体
    public GameObject zhuan; //第二个游戏物体，记录旋转的摄像头


    //移动速度
    private float speed = 0.5f;

    void Awake()
    {

    }

    //实时监测，并更新数据
    private void Update()
    {
        //ga.transform.Translate(new Vector3(,0,));
        if (isDown == true) //按钮按下时调用移动函数
        {
            Move();  
        }
    }

    void Move()
    {
        //zhuan.transform.forward表示第二个物体的前方，即z轴的方向
        //Time.deltaTime时间控制，随时间平滑变化
        //Space.Self以自身为坐标系
        ga.transform.position = new Vector3(ga.transform.position.x,0.169f,ga.transform.position.z);
        ga.transform.Translate(zhuan.transform.forward * -Time.deltaTime * speed, Space.Self);
    }



    //按钮按下抬起的信息记录
    [HideInInspector]
    public bool isDown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    //检测按钮按下的函数
    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
    }


    //检测按钮抬起的函数
    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = false;
    }
}
