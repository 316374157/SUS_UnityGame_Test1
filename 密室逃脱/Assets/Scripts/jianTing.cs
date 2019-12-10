using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class jianTing : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit = new RaycastHit();
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase.Equals(TouchPhase.Began))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                if (Physics.Raycast(ray,out hit,0.1f))
                {
                    hit.transform.gameObject.SendMessage("OnMouseDown");
                }
                
            }
        }
        
    }
}
