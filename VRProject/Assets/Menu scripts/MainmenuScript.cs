using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.IO;

public class MainmenuScript : MonoBehaviour
{
    public Button ButtonQuit;
    public Button QuitButtonCancel;
    public Button QuitButtonConfirm;
    public Text TextButtonQuit;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonQuitPressed()
    {
        TextButtonQuit.text = "Sure?";
    }

    public void ConfirmButtonQuit()
    {
        Application.Quit();
    }

    public void CancelButtonQuit()
    {
        TextButtonQuit.text = "Quit";
    }
}