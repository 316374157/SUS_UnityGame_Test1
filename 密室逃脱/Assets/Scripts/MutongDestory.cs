using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MutongDestory : MonoBehaviour
{
    public GameObject gmutong;//木桶物体
    Image image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mutong()
    {
        image = GameManager.button[GameManager.xiansuo].GetComponent<Image>();
        print(GameManager.st);
        if (GameManager.st != null)
        {
            if (image.sprite.name == "锤子")
            {
                gmutong.SetActive(false);
            }
        }       
    }
    private void OnMouseDown() 
    {
        mutong();   
    }
}
