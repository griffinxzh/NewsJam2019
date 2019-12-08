using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class poopBarMoving : MonoBehaviour
{
    public GameObject poopBar;
    float moving;
    float i = 0;
    float speed;
    public GameObject control;
    public int ending=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (control.GetComponent<PositionControl>().onKick == true)
        {
        moving = -330 * (1 - i);
        if (moving<=-3)
        {
            i += 0.001f;
         //   Debug.Log(moving);
            this.GetComponent<RectTransform>().anchoredPosition = new Vector2(moving, this.GetComponent<RectTransform>().anchoredPosition.y);
        }
        if (moving==-3)
        {
            ending = 1;
        }
    
        }
    }
}
