using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;

public class MainmenuScript : MonoBehaviour
{
    public Text txx;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText()
    {
        txx.text = "Privet";
    }

    public void quitGame()
    {
        Application.Quit();
    }
}