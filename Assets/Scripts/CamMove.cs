using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    int[] dir = { -1, 1 };
    int a;
    public float moveSpeed = 0.1f;
    public GameObject spyCam;

    // Start is called before the first frame update
    void Start()
    {
        a = dir[Random.Range(0,2)];
    }

    // Update is called once per frame
    void Update()
    {
        spyCam.transform.position = new Vector3(transform.position.x + moveSpeed * a, transform.position.y, transform.position.z);
        if (transform.position.x >= 10)
        {
            moveSpeed = moveSpeed * -1;
        }
        if (transform.position.x <= -10)
        {
            moveSpeed = moveSpeed * -1;
        }
    }


}
