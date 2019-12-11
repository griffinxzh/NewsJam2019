using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class UISwitch : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        VideoPlayer.loopPointReached += ShowButton;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ShowButton(VideoPlayer vp)
    {
        obj.SetActive(true);
    }
}
