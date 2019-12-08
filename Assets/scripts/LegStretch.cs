using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LegStretch : MonoBehaviour
{
    public GameObject leftLeg;
    public GameObject rightLeg;
    
    //public Transform lPosition;
    // public Transform rPosition;
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
        if (Input.GetKeyDown(KeyCode.I))
        {
            leftLeg.GetComponent<RectTransform>().anchoredPosition = new Vector2(xl, -10);
            Debug.Log("anxia");
            //leftLeg.transform.position = new Vector3(lPosition.position.x, lPosition.position.y + dist);
            onKick = false;
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            leftLeg.GetComponent<RectTransform>().anchoredPosition = new Vector2(xl, -80);
            Debug.Log("taiqi");
            // leftLeg.transform.position = new Vector3(lPosition.position.x, lPosition.position.y - dist);
            onKick = true;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            rightLeg.GetComponent<RectTransform>().anchoredPosition = new Vector2(xr,-10);
            Debug.Log("anxia");
            //   rightLeg.transform.position = new Vector3(rPosition.position.x, rPosition.position.y + dist);
            onKick = false;
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            rightLeg.GetComponent<RectTransform>().anchoredPosition = new Vector2(xr, yr);
            Debug.Log("taiqi");
            // rightLeg.transform.position = new Vector3(rPosition.position.x, rPosition.position.y - dist);
            onKick = true;
        }


    }
  

}
