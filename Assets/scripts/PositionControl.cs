using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionControl : MonoBehaviour
{
    public GameObject[] prePosition =  new GameObject[3];
    public GameObject leftLeg;
    public GameObject rightLeg;
    public GameObject legImage;
    public Material[] imageL=new Material[3];

    public Material[] imageM = new Material[3];

    public Material[] imageR = new Material[3];
    int index=1;

    float yl;
    float yr;
    float xl;
    float xr;

    public bool onKick = true;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {

        yl = leftLeg.GetComponent<RectTransform>().anchoredPosition.y;
        yr = rightLeg.GetComponent<RectTransform>().anchoredPosition.y;
        xl = leftLeg.GetComponent<RectTransform>().anchoredPosition.x;
        xr = rightLeg.GetComponent<RectTransform>().anchoredPosition.x;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (index > 0)
            {
                index -= 1;
                Debug.Log(index+"A");
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (index < 2)
            {
                index += 1;
                Debug.Log(index+"D");
            }


        }
        // transform.position = prePosition[index].position;
        leftLeg.GetComponent<RectTransform>().anchoredPosition = new Vector2(prePosition[index].GetComponent<RectTransform>().anchoredPosition.x - 120, prePosition[index].GetComponent<RectTransform>().anchoredPosition.y);
        rightLeg.GetComponent<RectTransform>().anchoredPosition = new Vector2(prePosition[index].GetComponent<RectTransform>().anchoredPosition.x + 120, prePosition[index].GetComponent<RectTransform>().anchoredPosition.y);

        if (Input.GetKeyDown(KeyCode.I))
        {
            leftLeg.GetComponent<RectTransform>().anchoredPosition = new Vector2(xl, -10);
           // Debug.Log("anxia");
            //leftLeg.transform.position = new Vector3(lPosition.position.x, lPosition.position.y + dist);
            onKick = false;


            if (index == 0)
            {
                legImage.GetComponent<Image>().material = imageL[1];
            }
            else if (index == 1)
            {
                legImage.GetComponent<Image>().material = imageM[1];
            }
            else if (index == 2)
            {
                legImage.GetComponent<Image>().material = imageR[1];
            }
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            leftLeg.GetComponent<RectTransform>().anchoredPosition = new Vector2(xl, -80);
           // Debug.Log("taiqi");
            // leftLeg.transform.position = new Vector3(lPosition.position.x, lPosition.position.y - dist);
            onKick = true;
            if (index == 0)
            {
                legImage.GetComponent<Image>().material = imageL[0];
            }
            else if (index == 1)
            {
                legImage.GetComponent<Image>().material = imageM[0];
            }
            else if (index == 2)
            {
                legImage.GetComponent<Image>().material = imageR[0];
            }
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            rightLeg.GetComponent<RectTransform>().anchoredPosition = new Vector2(xr, -10);
           
            //   rightLeg.transform.position = new Vector3(rPosition.position.x, rPosition.position.y + dist);
            onKick = false;
            if (index == 0)
            {
                legImage.GetComponent<Image>().material = imageL[2];
            }
            else if (index == 1)
            {
                legImage.GetComponent<Image>().material = imageM[2];
            }
            else if (index == 2)
            {
                legImage.GetComponent<Image>().material = imageR[2];
            }
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            rightLeg.GetComponent<RectTransform>().anchoredPosition = new Vector2(xr, yr);
           // rightLeg.transform.position = new Vector3(rPosition.position.x, rPosition.position.y - dist);
            onKick = true;
            if (index == 0)
            {
                legImage.GetComponent<Image>().material = imageL[0];
            }
            else if (index == 1)
            {
                legImage.GetComponent<Image>().material = imageM[0];
            }
            else if (index == 2)
            {
                legImage.GetComponent<Image>().material = imageR[0];
            }
        }
        

    }
}
