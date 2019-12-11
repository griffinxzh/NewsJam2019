using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{
    //public Slider slider;
    //public float spyCamStopper = 0.2f;
    //Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnKick");
        Destroy(GameObject.Find("EnemyCam(Clone)"));
        SpyCamSlider.camTimeRemaining -= 1f;
        //GetComponent<SpyCamSlider>().stopper = 2;
        //slider.value -= spyCamStopper;
    }

}
