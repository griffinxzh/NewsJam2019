using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpyCamSlider : MonoBehaviour
{
    public static float camTimeRemaining;
    private const float timerMax = 10f;
    public Slider slider;
    public float timerSpeed;
    //public float stopper;

    private void Start()
    {

    }

    private void Update()
    {
        slider.value = camTimeRemaining / timerMax;
        if (camTimeRemaining < 11)
        {
            camTimeRemaining = camTimeRemaining + Time.deltaTime * timerSpeed;
        }
        else if (camTimeRemaining >= 11)
        {
            return;
        }

        if(slider.value >= 1f)
        {
            Debug.Log("GameOver");
        }
    }
}
