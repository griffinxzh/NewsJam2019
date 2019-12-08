using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CamMoving : MonoBehaviour
{
    public int HP = 2;
    float speed=3;
   
    void Start()
    {
       
    }
    
    void Update()
    {
        if (this.GetComponent<RectTransform>().anchoredPosition.x > 330 || this.GetComponent<RectTransform>().anchoredPosition.x < -330)
        {
            speed = -1 * speed;
        }
        this.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.GetComponent<RectTransform>().anchoredPosition.x + speed, this.GetComponent<RectTransform>().anchoredPosition.y);
    }
    
}
