using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePanel : MonoBehaviour
{
    bool flag;
    public GameObject gameObject;
    Animator animator; //背包的
    RectTransform rect;

    Animator animator1; //标识按钮的
    Text text;
    public GameObject biaoshi;

   // public GameObject GetGame;
   // Image im;

    // Start is called before the first frame update
    private void Awake()
    {
        text = biaoshi.GetComponentInChildren<Text>();
        animator1 = biaoshi.GetComponent<Animator>();
        animator = gameObject.GetComponent<Animator>();
        rect = gameObject.GetComponent<RectTransform>();
        //im = GetGame.GetComponent<Image>();
    }
    void Start()
    {
        flag = false;
        animator.enabled = false;
        animator1.enabled = false;
    }
    public void Move()
    {
        animator1.enabled = true;
        animator.enabled = true;
        if (flag == false)
        {
            text.text = ">>>";
            animator1.Play("JAnimation1");
            animator.Play("JAnimation");
            flag = true;
        }
        else
        {
            text.text = "<<<";
            animator1.Play("CAnimation1");
            animator.Play("CAnimation");
            flag = false;
            //im.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
