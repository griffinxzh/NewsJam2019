using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpyGenerator : MonoBehaviour
{
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("EnemyCam(Clone)") == null)
        {
            Instantiate(cam, new Vector3(Random.Range(-10, 10), 1.71f), Quaternion.Euler(0, 0, 0));
        }
    }
}
