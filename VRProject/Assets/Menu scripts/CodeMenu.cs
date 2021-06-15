using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CodeMenu : MonoBehaviour
{
    public Text MoveText;
    public Text RotateRightText;
    public Text RotateLeftText;
    public Text RepeatText;
    public Text ValueText;
    public Button MoveButton;
    public Button RotateRightButton;
    public Button RotateLeftButton;
    public Button RepeatButton;
    public GameObject prefab;
    public RectTransform content;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateMove()
    {
        GameObject gm = Instantiate(this.prefab, this.content);
        gm.GetComponentInChildren<Text>().text = "MOVE " + ValueText.text + " STEPS";
    }

    public void GenerateRotateRight()
    {
        GameObject gm = Instantiate(this.prefab, this.content);
        gm.GetComponentInChildren<Text>().text = "ROTATE " + ValueText.text + " RIGHT";
    }

    public void GenerateRotateLeft()
    {
        GameObject gm = Instantiate(this.prefab, this.content);
        gm.GetComponentInChildren<Text>().text = "ROTATE " + ValueText.text + " LEFT";
    }

    public void GenerateRepeate()
    {
        GameObject gm = Instantiate(this.prefab, this.content);
        gm.GetComponentInChildren<Text>().text = "REPEAT " + ValueText.text + " TIMES";
        GenerateOpen();
        GenerateClose();
    }

    public void GenerateOpen()
    {
        GameObject gm = Instantiate(this.prefab, this.content);
        gm.GetComponentInChildren<Text>().text = "{";
    }

    public void GenerateClose()
    {
        GameObject gm = Instantiate(this.prefab, this.content);
        gm.GetComponentInChildren<Text>().text = "}";
    }

    public void NextValue()
    {
        ValueText.text = "" + (Convert.ToInt32(ValueText.text)+1);
        MoveText.text = "Move "+ ValueText.text + " steps";
        RotateRightText.text = "Rotate "+ ValueText.text + " right";
        RotateLeftText.text = "Rotate " + ValueText.text + " left";
        RepeatText.text = "Repeat " + ValueText.text + " times";
    }

    public void BackValue()
    {
        ValueText.text = "" + (Convert.ToInt32(ValueText.text) - 1);
        MoveText.text = "Move " + ValueText.text + " steps";
        RotateRightText.text = "Rotate " + ValueText.text + " right";
        RotateLeftText.text = "Rotate " + ValueText.text + " left";
        RepeatText.text = "Repeat " + ValueText.text + " times";
    }
}
