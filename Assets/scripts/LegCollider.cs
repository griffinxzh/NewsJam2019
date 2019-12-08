using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class LegCollider : MonoBehaviour
{
    public GameObject cam;
    int HP;

    public bool onkicking = false;
    // Start is called before the first frame update
    void Start()
    {
        HP = cam.GetComponent<CamMoving>().HP;
    }

    // Update is called once per frame
    void Update()
    {
        if (onkicking==true)
        {
            Invoke("camStart",2);
            onkicking = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        onkicking = true;

        if (HP >= 1)
        {
            HP -= 1;
            cam.GetComponent<CamMoving>().HP=HP;
        }
        else
        {
            cam.SetActive(false);
        }

    }
    void camStart()
    {
        cam.SetActive(true);
        cam.GetComponent<RectTransform>().anchoredPosition = new Vector2(-330,-43);
        
    }
}
