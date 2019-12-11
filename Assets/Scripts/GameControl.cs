using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject positionLeft;
    public GameObject positionMid;
    public GameObject positionRight;

    public GameObject leftLeg1;
    public GameObject rightLeg1;
    public GameObject leftLeg2;
    public GameObject rightLeg2;
    public GameObject leftLeg3;
    public GameObject rightLeg3;
    public GameObject mid1;
    public GameObject mid2;
    public GameObject mid3;
    // Start is called before the first frame update
    void Start()
    {
        positionMid.SetActive(true);
        positionRight.SetActive(false);
        positionLeft.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            positionMid.SetActive(false);
            positionRight.SetActive(false);
            positionLeft.SetActive(true);
            leftLeg1.SetActive(false);
            rightLeg1.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            positionMid.SetActive(true);
            positionRight.SetActive(false);
            positionLeft.SetActive(false);
            leftLeg2.SetActive(false);
            rightLeg2.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            positionMid.SetActive(false);
            positionRight.SetActive(true);
            positionLeft.SetActive(false);
            leftLeg3.SetActive(false);
            rightLeg3.SetActive(false);
        }

        //left position
        if (Input.GetKeyDown(KeyCode.A) && positionLeft == true)
        {
            leftLeg1.SetActive(true);
            mid1.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.A) && positionLeft == true)
        {
            leftLeg1.SetActive(false);
            mid1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.S) && positionLeft == true)
        {
            rightLeg1.SetActive(true);
            mid1.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.S) && positionLeft == true)
        {
            rightLeg1.SetActive(false);
            mid1.SetActive(true);
        }

        //mid position
        if (Input.GetKeyDown(KeyCode.A) && positionMid == true)
        {
            leftLeg2.SetActive(true);
            mid2.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.A) && positionLeft == true)
        {
            leftLeg2.SetActive(false);
            mid2.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.S) && positionLeft == true)
        {
            rightLeg2.SetActive(true);
            mid2.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.S) && positionLeft == true)
        {
            rightLeg2.SetActive(false);
            mid2.SetActive(true);
        }

        //right position
        if (Input.GetKeyDown(KeyCode.A) && positionRight == true)
        {
            leftLeg3.SetActive(true);
            mid3.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.A) && positionRight == true)
        {
            leftLeg3.SetActive(false);
            mid3.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.S) && positionRight == true)
        {
            rightLeg3.SetActive(true);
            mid3.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.S) && positionRight == true)
        {
            rightLeg3.SetActive(false);
            mid3.SetActive(true);
        }
    }
}
