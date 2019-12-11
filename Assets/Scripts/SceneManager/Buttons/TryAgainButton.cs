using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTryAgainButtonClick()
    {
        SceneManager.LoadScene(2);
        SpyCamSlider.camTimeRemaining = 0;
        PoopSlider.poopTimeRemaining = 0;
    }
}
