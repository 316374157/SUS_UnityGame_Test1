using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xiaoshi : MonoBehaviour
{
    public GameObject GetGame;
    Image image;

    public Transform transform;


    public GameObject Ck;  //查看背景
    public Transform Ck1;  //查看系

    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        Ck.SetActive(true);
        for (int i =0;i<Ck1.childCount;i++)
        {
            if (GetGame.name == Ck1.GetChild(i).name)
            {
                Ck1.GetChild(i).gameObject.SetActive(true);
            }
        }

        for(int i=0;i<transform.childCount;i++)
        {     
            if (GameManager.flag[i] == true)
            {
                image = transform.GetChild(i).gameObject.GetComponent<Image>();
                image.sprite = Resources.Load(GetGame.name, typeof(Sprite)) as Sprite;
                GameManager.flag[i] = false;
                Destroy(GetGame);
                break;
            }

        }    
        
    }

    private void OnMouseDown()
    {
        Click();
    }
}
