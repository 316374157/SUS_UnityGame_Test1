using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int xiansuo = 0;//记录哪个button(线索)被选中着

    public static bool liang = false;//标记是否已点击一个button了，说明已有颜色变化

    public Transform transform;//将装着多个button的content赋值过去
    public static bool[] flag = new bool[11];   //是否可以更换图片
    public static bool queding;
    public static string st = null;



    //public static bool[] flag1 = new bool[11]; //是否高亮

    public static List<GameObject> button = new List<GameObject>(); //背包按钮

    // Start is called before the first frame update
    void Start()
    {
        //按钮是否能够改变背景
        for (int i = 0; i < 11; i++)
        {
            flag[i] = true;
        }

        //是否被选中
        /*for (int i = 0; i < 11; i++)
        {
            flag1[i] = false;
        }*/

        //获取背包
        //int num = 0;//测试记录button的个数
        for (int i = 0; i < transform.childCount; i++)
        {
            button.Add(transform.GetChild(i).gameObject);
            //num++;
        }
        //print(num);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
