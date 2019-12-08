using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camBarMoving : MonoBehaviour
{
    public GameObject camBar;
    float moving;
    float i = 0;
    float speed;
    public GameObject Cam;
    private int hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hp = Cam.GetComponent<CamMoving>().HP;
        //if (poopBar.GetComponent<Mainrule>().gameState)
        //{
        // i = (float)poopBar.GetComponent<Money>().money / 1000000000f;
        moving = 330 * (1 - i);
        if (hp != 0)
        {
            if (moving >= 3)
            {
                i += 0.001f;
                // Debug.Log(moving);
                this.GetComponent<RectTransform>().anchoredPosition = new Vector2(moving, this.GetComponent<RectTransform>().anchoredPosition.y);
            }
        }
       
        //if (hp == 0)
        //{
        //    this.GetComponent<RectTransform>().anchoredPosition = new Vector2(this.GetComponent<RectTransform>().anchoredPosition.x+30, this.GetComponent<RectTransform>().anchoredPosition.y);
        //}

        // }
    }
}
