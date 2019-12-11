using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoopSlider : MonoBehaviour
{
    public static float poopTimeRemaining;
    private const float timerMax = 10f;
    public Slider slider;
    public float timerSpeed;

    private void Start()
    {
        
    }

    private void Update()
    {
        slider.value = poopTimeRemaining / timerMax;
        if (poopTimeRemaining < 11)
        {
            poopTimeRemaining += Time.deltaTime * timerSpeed;
        }
        else if (poopTimeRemaining >= 11)
        {
            return;
        }
        if (slider.value >= 1f)
        {
            Debug.Log("Win!");
        }
    }

}
