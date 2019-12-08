using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainrule : MonoBehaviour
{
    public int CamHp;
    //public int PoopHp;
    public GameObject prefab;
    float speed=3;
    GameObject cam;

   // public GameObject camdamage;
   // int state=1;
    // Start is called before the first frame update
    void Start()
    {
        genCam();
    }

    // Update is called once per frame
    void Update()
    {
        moveCam();
        //if (state == 1)
        //{
        //    cam = camdamage;
        //}
    }
    void genCam()
    {
        cam= Instantiate(prefab, new Vector2(280, 450), Quaternion.identity);
    }
    void moveCam()
    {
            if (cam.GetComponent<Transform>().position.x > 745 || cam.GetComponent<Transform>().position.x < 280)
            {
                speed = -1 * speed;
            }
            cam.GetComponent<Transform>().position = new Vector2(cam.GetComponent<Transform>().position.x + speed, cam.GetComponent<Transform>().position.y);
    }
}
