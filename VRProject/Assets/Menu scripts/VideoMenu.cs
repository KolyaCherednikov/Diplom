using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoMenu : MonoBehaviour
{
    public Scrollbar scrollbar;
    public Text FOVtext;
    public Camera VRcam;
    public Camera Testcam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TextWithFOV()
    {
        FOVtext.text = "" + Convert.ToInt32((60 + (scrollbar.value * 30)));
        FOVtext.text = "" + FOVtext.text[0] + FOVtext.text[1];
        VRcam.fieldOfView = 60 + (scrollbar.value * 30);
        Testcam.fieldOfView = 60 + (scrollbar.value * 30);
    }
}
