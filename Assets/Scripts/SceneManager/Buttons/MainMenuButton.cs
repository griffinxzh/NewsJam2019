using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void OnMainMenuButtonClick()
    {
        SceneManager.LoadScene(1);
        SpyCamSlider.camTimeRemaining = 0;
        PoopSlider.poopTimeRemaining = 0;
    }
}
