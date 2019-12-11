using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WatchAgainButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnWatchAgainButtonClick()
    {
        SceneManager.LoadScene(0);
        SpyCamSlider.camTimeRemaining = 0;
        PoopSlider.poopTimeRemaining = 0;
    }
}
